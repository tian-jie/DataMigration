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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World1!");
            ak = ConfigurationManager.AppSettings["s3ak"];
            sk = ConfigurationManager.AppSettings["s3sk"];
            region = Amazon.RegionEndpoint.CNNorthWest1;
            bucketName = ConfigurationManager.AppSettings["bucketName"];
            dbName = ConfigurationManager.AppSettings["dbName"];

            // 获取需要导入的表
            var s3Client = new AmazonS3Client(ak, sk, Amazon.RegionEndpoint.CNNorthWest1);
            TransferUtility fileTransferUtility = new TransferUtility(s3Client);
            Console.WriteLine("starting to get import table list from s3...");
            fileTransferUtility.Download("index.ls", bucketName, $"datamigration/{dbName}/index.ls");
            string[] importList;
            using (StreamReader sr = new StreamReader("index.ls"))
            {
                string str = sr.ReadToEnd();
                importList = str.Split(new char[] { '\n', '\r' });
            }

            var d = new IdoctorDctr();

            var tasks = new List<Task>();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var modelAssembly = assemblies.FirstOrDefault(a => a.ManifestModule.Name == "Models.dll");

            foreach (var import in importList)
            {
                if (!string.IsNullOrEmpty(import))
                {
                    tasks.Add((Task)typeof(Program).GetMethod("Import").MakeGenericMethod(modelAssembly.GetType(import, true, true)).Invoke(null, null));
                }
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static async Task Import<T>() where T : IEntity, new()
        {
            var tableName = typeof(T).Name;
            var key = $"datamigration/{dbName}/{tableName}.json";
            Console.WriteLine($"Downloading {tableName}...");
            // 从S3上拉文件下来

            AmazonS3Config s3Config = new AmazonS3Config();
            var s3Client = new AmazonS3Client(ak, sk, region);

            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Restart();

            TransferUtility fileTransferUtility = new TransferUtility(s3Client);
            await fileTransferUtility.DownloadAsync("files/" + key, bucketName, key);

            Console.WriteLine($"downloaded file {tableName} to local folder: {watch.ElapsedMilliseconds / 1000.0}s");

            // TODO: 读取json文件
            List<T> result;
            using (StreamReader sr = new StreamReader("files/" + key))
            {
                string json = sr.ReadToEnd();
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
            }
            Console.WriteLine($"finished deserialize<{tableName}>: {watch.ElapsedMilliseconds / 1000.0}s, total {result.Count} records");
            Console.WriteLine($"start to import {tableName} to pg database...");


            // 将文件导入到PG数据库里
            var connString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
            DbContextOptions<PostgreSQLContext> dbContextOption = new DbContextOptions<PostgreSQLContext>();
            DbContextOptionsBuilder<PostgreSQLContext> dbContextOptionBuilder = new DbContextOptionsBuilder<PostgreSQLContext>(dbContextOption);
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            var db = new PostgreSQLContext(dbContextOptionBuilder.UseNpgsql(connString).Options);

            // TODO: 根据数量循环一下，还是10000条commit一次吧

            await db.AddRangeAsync(result);
            await db.SaveChangesAsync();

            await db.DisposeAsync();

            watch.Stop();
            Console.WriteLine($"finished import {tableName} to db: {watch.ElapsedMilliseconds / 1000.0}s");

        }
    }
}
