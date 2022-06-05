using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using testdbspeed;

namespace Import
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var task = Import("AKIA6C2GIRPYF3UOMZHG", "4ZfqesRbGIqCusIBowcE1TCxNQELx5Ald3ZxiTw7", Amazon.RegionEndpoint.CNNorthWest1, "lly-nw-com-lccp-d-s3-pri-01", "datamigration/Lilly_DXY_Data_BgmBehavior.json");
            task.Wait();
        }

        public static async Task Import(string ak, string sk, Amazon.RegionEndpoint region, string bucketName, string key)
        {
            // TODO: 从S3上拉文件下来

            AmazonS3Config s3Config = new AmazonS3Config();
            var s3Client = new AmazonS3Client(ak, sk, region);

            TransferUtility fileTransferUtility = new TransferUtility(s3Client);

            GetObjectRequest request = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            };

            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Restart();

            await fileTransferUtility.DownloadAsync("files/" + key, bucketName, key);


            //using (GetObjectResponse response = s3Client.GetObjectAsync(request).Result)
            //{
            //    using (Stream responseStream = response.ResponseStream)
            //    {
            //        using (StreamReader reader = new StreamReader(responseStream))
            //        {
            //            string title = response.Metadata["x-amz-meta-title"];
            //            json = reader.ReadToEnd();
            //        }
            //    }
            //}
            watch.Stop();
            Console.WriteLine("download file to local foler: ", watch.ElapsedMilliseconds / 1000.0);

            watch.Restart();

            // TODO: 读取json文件
            List<Lilly_DXY_Data_BgmBehavior> result;
            using (StreamReader sr = new StreamReader("files/" + key))
            {
                string json = sr.ReadToEnd();
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Lilly_DXY_Data_BgmBehavior>>(json);
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine($"record count: {result.Count}");


            // TODO: 将文件导入到PG数据库里

        }
    }
}
