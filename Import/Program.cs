using System;
using System.Collections.Generic;
using System.IO;
using Amazon.S3;
using Amazon.S3.Model;
using testdbspeed;

namespace Import
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // TODO: 从S3上拉文件下来

            AmazonS3Config s3Config = new AmazonS3Config();
            var s3Client = new AmazonS3Client("AKIA6C2GIRPYF3UOMZHG", "4ZfqesRbGIqCusIBowcE1TCxNQELx5Ald3ZxiTw7", Amazon.RegionEndpoint.CNNorthWest1);

            Amazon.S3.Model.GetObjectRequest request = new Amazon.S3.Model.GetObjectRequest
            {
                BucketName = "lly-nw-com-lccp-d-s3-pri-01",
                Key = "Lilly_DXY_Data_BgmBehavior.json",
                //Key = "54b8669f-e581-48d3-be87-011ac8d60712"
            };

            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Restart();

            string json = "";
            using (GetObjectResponse response = s3Client.GetObjectAsync(request).Result)
            {
                using (Stream responseStream = response.ResponseStream)
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        string title = response.Metadata["x-amz-meta-title"];
                        json = reader.ReadToEnd();
                    }
                }
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds / 1000.0);

            watch.Restart();

            // TODO: 读取json文件
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Lilly_DXY_Data_BgmBehavior>>(json);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine($"record count: {result.Count}");


            // TODO: 将文件导入到PG数据库里

        }
    }
}
