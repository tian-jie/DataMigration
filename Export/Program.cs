using Amazon.S3;
using Amazon.S3.Transfer;
using Infrastructure.Core;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdbspeed
{
    class Program
    {
        static string ak;
        static string sk;
        static Amazon.RegionEndpoint region = Amazon.RegionEndpoint.CNNorthWest1;
        static string bucketName;
        static string dbName;
        static int pageSize;

        static List<ExportResult> exportResults = new List<ExportResult>();

        static void Main(string[] args)
        {
            Log("Hello World!");

            ak = ConfigurationManager.AppSettings["s3ak"];
            sk = ConfigurationManager.AppSettings["s3sk"];
            region = Amazon.RegionEndpoint.CNNorthWest1;
            bucketName = ConfigurationManager.AppSettings["bucketName"];
            dbName = ConfigurationManager.AppSettings["dbName"];
            pageSize = int.Parse(ConfigurationManager.AppSettings["exportPageSize"]);

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
            Log("starting to get export table list from s3...");
            Log("key: {0}", $"datamigration/{dbName}/index.ls");
            fileTransferUtility.Download("index.ls", bucketName, $"datamigration/{dbName}/index.ls");

            string[] exportList;
            using (StreamReader sr = new StreamReader("index.ls"))
            {
                string str = sr.ReadToEnd();
                exportList = str.Split(new char[] { '\n', '\r' });
            }
#endif

            // 创建导出结果的list
            foreach (var export in exportList)
            {
                exportResults.Add(new ExportResult()
                {
                    TableName = export,
                    Pages = 0,
                    Status = ExportStatus.NotStarted
                });
            }

            // 用反射获取对象并循环导出
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var modelAssembly = assemblies.FirstOrDefault(a => a.ManifestModule.Name == "Models.dll");

            foreach (var export in exportList)
            {
                if (!string.IsNullOrEmpty(export) && !export.Trim().StartsWith("#"))
                {
                    typeof(Program).GetMethod("Export").MakeGenericMethod(modelAssembly.GetType(export, true, true)).Invoke(null, null);
                }
            }

            Log("Good bye World!");
        }

        public static void Export<T>() where T : IEntity, new()
        {
            try
            {
                var tableName = typeof(T).Name;
                var json = "";

                Log($"Exporting {tableName} is starting...");

                var connConfig = new SqlSugar.ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.SqlServer,         //必填, 数据库类型
                    IsAutoCloseConnection = true,               //默认false, 时候知道关闭数据库连接, 设置为true无需使用using或者Close操作
                    InitKeyType = InitKeyType.SystemTable,
                    ConnectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString
                };

                var ss = new SqlSugar.SqlSugarClient(connConfig);

                AmazonS3Config s3Config = new AmazonS3Config();
                var s3Client = new AmazonS3Client(ak, sk, region);
                TransferUtility fileTransferUtility = new TransferUtility(s3Client);

                var tasks = new List<Task>();
                for (var index = 0; ; index++)
                {
                    Log($"Exporting {tableName}.{index.ToString("D4")} is starting...");
                    var exportResult = exportResults.FirstOrDefault(a => a.TableName == tableName);
                    exportResult.Status = ExportStatus.Failed;
                    json = ss.SqlQueryable<T>($"SELECT * FROM {tableName} ORDER BY id OFFSET {pageSize * index} ROWS FETCH NEXT {pageSize} ROWS ONLY").ToJson();
                    if (json.Length < 10)
                    {
                        break;
                    }
                    Log($"Exporting {tableName}.{index.ToString("D4")} from db is finished");
                    var key = $"datamigration/{dbName}/{tableName}/{tableName}.{index.ToString("D4")}.json";

                    UploadToS3(json, fileTransferUtility, key, tableName, index);
                    exportResult.Status = ExportStatus.Success;
                    exportResult.Pages = index - 1;
                }

                Log($"Export {tableName} finished.");
                return;
            }
            catch (Exception ex)
            {
                Log($"Error Occurred: {ex.Message}");
            }
        }

        public static void UploadToS3(string json, TransferUtility fileTransferUtility, string key, string tableName, int index)
        {
            Log($"Upload {tableName}.{index.ToString("D4")} to s3 is finished");
            using (MemoryStream ms = new MemoryStream())
            {
                var utf8 = Encoding.UTF8;
                byte[] utfBytes = utf8.GetBytes(json);
                ms.Write(utfBytes);
                fileTransferUtility.Upload(ms, bucketName, key);
            }

            Log($"Upload {tableName}.{index.ToString("D4")} to s3 is finished");
        }

        private static void Log(string s)
        {
            Console.WriteLine("Migration - " + s);
        }
    }
}
