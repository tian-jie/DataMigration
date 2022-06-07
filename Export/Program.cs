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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ak = ConfigurationManager.AppSettings["s3ak"];
            sk = ConfigurationManager.AppSettings["s3sk"];
            region = Amazon.RegionEndpoint.CNNorthWest1;
            bucketName = ConfigurationManager.AppSettings["bucketName"];
            dbName = ConfigurationManager.AppSettings["dbName"];

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


            List<Task> tasks = new List<Task>();
            //tasks.Add(Export<Lilly_DXY_Data_Cards>(ak, sk, region, bucketName));
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var modelAssembly = assemblies.FirstOrDefault(a => a.ManifestModule.Name == "Models.dll");

            foreach(var export in exportList)
            {
                if (!string.IsNullOrEmpty(export))
                {
                    tasks.Add((Task)typeof(Program).GetMethod("Export").MakeGenericMethod(modelAssembly.GetType(export, true, true)).Invoke(null, null));
                }
            }

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine("Good bye World!");
        }

        public static async Task Export<T>() where T : IEntity, new()
        {
            try
            {
                var tableName = typeof(T).Name;
                var key = $"datamigration/{dbName}/{tableName}.json";
                Console.WriteLine($"Exporting {tableName} is starting...");

                System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
                watch.Restart();

                var connConfig = new SqlSugar.ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.SqlServer,         //必填, 数据库类型
                    IsAutoCloseConnection = true,               //默认false, 时候知道关闭数据库连接, 设置为true无需使用using或者Close操作
                    InitKeyType = InitKeyType.SystemTable,
                    ConnectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString
                };

                var ss = new SqlSugar.SqlSugarClient(connConfig);
                var json = ss.SqlQueryable<T>($"select * from {tableName}").ToJson();


                // TODO: 查找s3上是否有相应的内容，有的话就删掉，然后上传，不用保存
                AmazonS3Config s3Config = new AmazonS3Config();
                var s3Client = new AmazonS3Client(ak, sk, region);

                TransferUtility fileTransferUtility = new TransferUtility(s3Client);
                using (MemoryStream ms = new MemoryStream())
                {
                    var utf8 = Encoding.UTF8;
                    byte[] utfBytes = utf8.GetBytes(json);
                    await ms.WriteAsync(utfBytes);
                    await fileTransferUtility.UploadAsync(ms, bucketName, key);
                }


                watch.Stop();
                Console.WriteLine($"Exporting {tableName} finished, time spent: {watch.ElapsedMilliseconds / 1000.0} s");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occurred: {ex.Message}");
            }
        }
    }
}
