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

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var modelAssembly = assemblies.FirstOrDefault(a => a.ManifestModule.Name == "Models.dll");

            foreach (var import in importList)
            {
                if (!string.IsNullOrEmpty(import) && !import.Trim().StartsWith("#"))
                {
                    typeof(Program).GetMethod("Import").MakeGenericMethod(modelAssembly.GetType(import, true, true)).Invoke(null, null);
                }
            }

        }
        public static void Import<T>() where T : IEntity, new()
        {
            var tableName = typeof(T).Name;
            Console.WriteLine($"Start to importing {tableName}...");
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            try
            {
                // 从S3上拉文件下来

                AmazonS3Config s3Config = new AmazonS3Config();
                var s3Client = new AmazonS3Client(ak, sk, region);

                watch.Restart();
                // 将文件导入到数据库里
                var db = GetDbContext();

                TransferUtility fileTransferUtility = new TransferUtility(s3Client);
                var tasks = new List<Task>();
                for (var i = 0; ; i++)
                {
                    var key = $"datamigration/{dbName}/{tableName}/{tableName}.{i.ToString("D4")}.json";

                    Console.WriteLine($"start to download file {tableName}.{i.ToString("D4")} to local folder: {watch.ElapsedMilliseconds / 1000.0}s");
                    lock (downloadLocker)
                    {
                        try
                        {
                            fileTransferUtility.Download("files/" + key, bucketName, key);
                        }
                        catch (Amazon.S3.AmazonS3Exception s3Exception)
                        {
                            Console.WriteLine($"file all downloaded - {s3Exception.Message}");
                            break;
                        }
                    }
                    Console.WriteLine($"finished to download file {tableName}.{i.ToString("D4")} to local folder: {watch.ElapsedMilliseconds / 1000.0}s");

                    // 读取json文件
                    List<T> result;
                    Console.WriteLine($"  start to deserialize<{tableName}>: {watch.ElapsedMilliseconds / 1000.0}s");
                    using (StreamReader sr = new StreamReader("files/" + key))
                    {
                        string json = sr.ReadToEnd();
                        result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
                    }

                    File.Delete("files/" + key);
                    Console.WriteLine($"  finished deserialize<{tableName}>: {watch.ElapsedMilliseconds / 1000.0}s, total {result.Count} records");

                    var task = ImportToDB<T>(tableName, key, watch, db, i, result);
                    task.Wait();
                }

                //Task.WaitAll(tasks.ToArray());
                db.Dispose();

                Console.WriteLine($"finished import {tableName} to db: {watch.ElapsedMilliseconds / 1000.0}s");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error occurred on importing {tableName}: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Error Occurred: {ex.InnerException.Message}");
                }
            }
            finally
            {
                watch.Stop();
            }
        }


        private static DbContext GetDbContext()
        {
            return new PostgreSQLContext(ConfigurationManager.AppSettings["schemaName"]);
        }

        private static async Task ImportToDB<T>(string tableName, string key, System.Diagnostics.Stopwatch watch, DbContext db, int page, List<T> result) where T : class, new()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"  start to import {tableName}.{page.ToString("D4")} to pg database... - {watch.ElapsedMilliseconds / 1000.0}s");

                db.BulkInsert(result, options => options.InsertKeepIdentity = true);
                //db.AddRange(result);
                //Console.WriteLine($"  data added to {tableName}.{i.ToString("D4")} to mssql database... - {watch.ElapsedMilliseconds / 1000.0}s");
                //db.BulkSaveChanges();
                Console.WriteLine($"  finished to import {tableName}.{page.ToString("D4")} to pg database... - {watch.ElapsedMilliseconds / 1000.0}s");
            });
        }
    }
}
