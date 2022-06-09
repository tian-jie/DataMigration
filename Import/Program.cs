using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Infrastructure.Core;
using Innocellence.DXYDataTransfer.Models;
using InnoCellence.Lccp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Import
{
    class Program
    {
        static string ak;
        static string sk;
        static Amazon.RegionEndpoint region = Amazon.RegionEndpoint.CNNorthWest1;
        static string bucketName;
        static string dbName;
        static object downloadLocker = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World1!");
            ak = ConfigurationManager.AppSettings["s3ak"];
            sk = ConfigurationManager.AppSettings["s3sk"];
            region = Amazon.RegionEndpoint.CNNorthWest1;
            bucketName = ConfigurationManager.AppSettings["bucketName"];
            dbName = ConfigurationManager.AppSettings["dbName"];

#if DEBUG
            string[] importList;
            using (StreamReader sr = new StreamReader("index.ls"))
            {
                string str = sr.ReadToEnd();
                importList = str.Split(new char[] { '\n', '\r' });
            }
#else

            // 获取需要导出的表
            var s3Client = new AmazonS3Client(ak, sk, Amazon.RegionEndpoint.CNNorthWest1);
            TransferUtility fileTransferUtility = new TransferUtility(s3Client);
            Console.WriteLine("starting to get export table list from s3...");
            Console.WriteLine("key: {0}", $"datamigration/{dbName}/index.ls");
            fileTransferUtility.Download("index.ls", bucketName, $"datamigration/{dbName}/index.ls");

            string[] importList;
            using (StreamReader sr = new StreamReader("index.ls"))
            {
                string str = sr.ReadToEnd();
                importList = str.Split(new char[] { '\n', '\r' });
            }
#endif


            var d = new IdoctorDctr();

            var tasks = new List<Task>();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var modelAssembly = assemblies.FirstOrDefault(a => a.ManifestModule.Name == "Models.dll");

            foreach (var import in importList)
            {
                if (!string.IsNullOrEmpty(import) && !import.Trim().StartsWith("#"))
                {
                    tasks.Add((Task)typeof(Program).GetMethod("Import").MakeGenericMethod(modelAssembly.GetType(import, true, true)).Invoke(null, null));
                }
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static async Task Import<T>() where T : IEntity, new()
        {
            var tableName = typeof(T).Name;
            Console.WriteLine($"Downloading {tableName}...");
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            // 将文件导入到PG数据库里
            var connString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
            DbContextOptions<PostgreSQLContext> dbContextOption = new DbContextOptions<PostgreSQLContext>();
            DbContextOptionsBuilder<PostgreSQLContext> dbContextOptionBuilder = new DbContextOptionsBuilder<PostgreSQLContext>(dbContextOption);
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            var db = new PostgreSQLContext(dbContextOptionBuilder.UseNpgsql(connString).Options);

            watch.Restart();

            for (var i = 0; ; i++)
            {
                var key = $"datamigration/{dbName}/{tableName}/{tableName}.{i.ToString("D4")}.json";
                Console.WriteLine($"Downloading {key}...");

                var s3Client = new AmazonS3Client(ak, sk, region);

                // 从S3上拉文件下来
                lock (downloadLocker)
                {

                    TransferUtility fileTransferUtility = new TransferUtility(s3Client);
                    try
                    {
                        fileTransferUtility.Download("files/" + key, bucketName, key);
                    }
                    catch(Exception ex)
                    {
                        if (ex.Message.Contains("The specified key does not exist"))
                        {
                            break;
                        }
                        Console.WriteLine(ex.Message);
                        break;
                    }

                    Console.WriteLine($"downloaded file {key} to local folder: {watch.ElapsedMilliseconds / 1000.0}s");
                }
                // TODO: 读取json文件
                List<T> result;
                using (StreamReader sr = new StreamReader("files/" + key))
                {
                    string json = sr.ReadToEnd();
                    result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
                }
                Console.WriteLine($"finished deserialize<{tableName}>: {watch.ElapsedMilliseconds / 1000.0}s, total {result.Count} records");
                File.Delete("files/" + key);
                Console.WriteLine($"start to import {tableName} to pg database...");


                // TODO: 根据数量循环一下，还是10000条commit一次吧
                await db.AddRangeAsync(result);
                await db.SaveChangesAsync();

            }
            await db.DisposeAsync();

            watch.Stop();
            Console.WriteLine($"finished import {tableName} to db: {watch.ElapsedMilliseconds / 1000.0}s");

        }
    }
}
