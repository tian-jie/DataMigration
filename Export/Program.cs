using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Infrastructure.Core;
using Innocellence.DXYDataTransfer.Models;
using InnoCellence.Lccp.Data.Models;
using SqlSugar;
using System.Linq;

namespace testdbspeed
{
    class Program
    {
        static string ak;
        static string sk;
        static Amazon.RegionEndpoint region = Amazon.RegionEndpoint.CNNorthWest1;
        static string bucketName;
        static string dbName;
        static object locker = new object();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ak = ConfigurationManager.AppSettings["s3ak"];
            sk = ConfigurationManager.AppSettings["s3sk"];
            region = Amazon.RegionEndpoint.CNNorthWest1;
            bucketName = ConfigurationManager.AppSettings["bucketName"];
            dbName = ConfigurationManager.AppSettings["dbName"];

#if DEBUG
            string[] exportList;
            using (StreamReader sr = new StreamReader("index.ls"))
            {
                string str = sr.ReadToEnd();
                exportList = str.Split(new char[] { '\n', '\r' });
            }
#else

            // 获取需要导出的表
            var s3Client = new AmazonS3Client(ak, sk, Amazon.RegionEndpoint.CNNorthWest1);
            TransferUtility fileTransferUtility = new TransferUtility(s3Client);
            Console.WriteLine("starting to get export table list from s3...");
            Console.WriteLine("key: {0}", $"datamigration/{dbName}/index.ls");
            fileTransferUtility.Download("index.ls", bucketName, $"datamigration/{dbName}/index.ls");

            string[] exportList;
            using (StreamReader sr = new StreamReader("index.ls"))
            {
                string str = sr.ReadToEnd();
                exportList = str.Split(new char[] { '\n', '\r' });
            }
#endif

            List<Task> tasks = new List<Task>();
            //tasks.Add(Export<Lilly_DXY_Data_Cards>(ak, sk, region, bucketName));
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var modelAssembly = assemblies.FirstOrDefault(a => a.ManifestModule.Name == "Models.dll");

            foreach (var export in exportList)
            {
                if (!string.IsNullOrEmpty(export) && !export.Trim().StartsWith("#"))
                {
                    var task = (Task)typeof(Program).GetMethod("Export").MakeGenericMethod(modelAssembly.GetType(export, true, true)).Invoke(null, null);
                    task.Wait();
                }
            }

            Console.WriteLine("Good bye World!");
        }

        public static Task Export<T>() where T : IEntity, new()
        {
            return Task.Run(() =>
            {
                try
                {
                    var tableName = typeof(T).Name;
                    var json = "";
                    System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

                    Console.WriteLine($"Exporting {tableName} is starting...");

                    watch.Restart();
                    var connConfig = new SqlSugar.ConnectionConfig()
                    {
                        DbType = SqlSugar.DbType.SqlServer,         //必填, 数据库类型
                        IsAutoCloseConnection = true,               //默认false, 时候知道关闭数据库连接, 设置为true无需使用using或者Close操作
                        InitKeyType = InitKeyType.SystemTable,
                        ConnectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString
                    };


                    var ss = new SqlSugar.SqlSugarClient(connConfig);

                    // 每100万一个包
                    var pageSize = int.Parse(ConfigurationManager.AppSettings["exportPageSize"]);

                    //var cnt = ss.SqlQueryable<T>($"select count(1) CountTable from {tableName}").Count();
                    //var totalPages = cnt % pageSize > 0 ? 1 : 0;
                    //Console.WriteLine($"record count of {tableName} is {cnt}, will split to {totalPages} pages - time: {watch.ElapsedMilliseconds / 1000.0} s");

                    AmazonS3Config s3Config = new AmazonS3Config();
                    var s3Client = new AmazonS3Client(ak, sk, region);
                    TransferUtility fileTransferUtility = new TransferUtility(s3Client);

                    // TODO: 查找s3上是否有相应的内容，有的话就删掉，然后上传

                    var tasks = new List<Task>();
                    for (var index = 0; ; index++)
                    {
                        Console.WriteLine($"Exporting {tableName}.{index.ToString("D4")} is starting... - time: {watch.ElapsedMilliseconds / 1000.0} s");

                        json = ss.SqlQueryable<T>($"SELECT * FROM {tableName} ORDER BY id OFFSET {pageSize * index} ROWS FETCH NEXT {pageSize} ROWS ONLY").ToJson();
                        if (json.Length < 10)
                        {
                            break;
                        }
                        Console.WriteLine($"Exporting {tableName}.{index.ToString("D4")} from db is finished - time: {watch.ElapsedMilliseconds / 1000.0} s");
                        var key = $"datamigration/{dbName}/{tableName}/{tableName}.{index.ToString("D4")}.json";

                        var task = UploadToS3(json, fileTransferUtility, key, tableName, index, watch);
                        tasks.Add(task);
                    }

                    Task.WaitAll(tasks.ToArray());

                    watch.Stop();
                    Console.WriteLine($"Export {tableName} finished, time spent: {watch.ElapsedMilliseconds / 1000.0} s");
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Occurred: {ex.Message}");
                }
            });
        }

        public static Task UploadToS3(string json, TransferUtility fileTransferUtility, string key, string tableName, int index, System.Diagnostics.Stopwatch watch)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"Upload {tableName}.{index.ToString("D4")} to s3 is finished - time: {watch.ElapsedMilliseconds / 1000.0} s");
                using (MemoryStream ms = new MemoryStream())
                {
                    var utf8 = Encoding.UTF8;
                    byte[] utfBytes = utf8.GetBytes(json);
                    ms.Write(utfBytes);
                    fileTransferUtility.Upload(ms, bucketName, key);
                }

                Console.WriteLine($"Upload {tableName}.{index.ToString("D4")} to s3 is finished - time: {watch.ElapsedMilliseconds / 1000.0} s");
            });
        }
    }
}
