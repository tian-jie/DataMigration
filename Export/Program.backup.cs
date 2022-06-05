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

namespace testdbspeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ak = "AKIA6C2GIRPYF3UOMZHG";
            var sk = "4ZfqesRbGIqCusIBowcE1TCxNQELx5Ald3ZxiTw7";
            var region = Amazon.RegionEndpoint.CNNorthWest1;
            var bucketName = "lly-nw-com-lccp-d-s3-pri-01";

            // TODO: 尝试执行一个外面写的代码段。
            List<Task> tasks = new List<Task>();
            //tasks.Add(Export<Lilly_DXY_Data_Cards>(ak, sk, region, bucketName));
            //###tableNames###

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine("Good bye World!");
        }

        public static async Task Export<T>(string ak, string sk, Amazon.RegionEndpoint region, string bucketName) where T : IEntity, new()
        {
            try
            {
                var tableName = typeof(T).Name;
                var key = $"datamigration/{tableName}.json";
                Console.WriteLine($"Exporting {tableName} is starting...");

                System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
                watch.Restart();

                var connConfig = new SqlSugar.ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.SqlServer,         //必填, 数据库类型
                    IsAutoCloseConnection = true,               //默认false, 时候知道关闭数据库连接, 设置为true无需使用using或者Close操作
                    InitKeyType = InitKeyType.SystemTable,
                    ConnectionString = "Data Source=localhost;Initial Catalog=LCCP;Persist Security Info=True;User ID=sa;Password=Tj800514"
                };

                var ss = new SqlSugar.SqlSugarClient(connConfig);
                var json = ss.SqlQueryable<T>($"select * from {tableName}").ToJson();


                // TODO: 查找s3上是否有相应的内容，有的话就删掉，然后上传，不用保存
                AmazonS3Config s3Config = new AmazonS3Config();
                var s3Client = new AmazonS3Client(ak, sk, region);

                TransferUtility fileTransferUtility = new TransferUtility(s3Client);

                //try
                //{
                //    var objMetadata = await s3Client.GetObjectMetadataAsync(bucketName, key);
                //    // 删除
                //    var deleteResponse = await s3Client.DeleteObjectAsync(bucketName, key);
                //    if (deleteResponse.HttpStatusCode != System.Net.HttpStatusCode.OK)
                //    {
                //        throw new Exception("Cannot remove old S3 files.");
                //    }
                //}
                //catch
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        var utf8 = Encoding.UTF8;
                        byte[] utfBytes = utf8.GetBytes(json);
                        await ms.WriteAsync(utfBytes);
                        await fileTransferUtility.UploadAsync(ms, bucketName, key);
                    }
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
