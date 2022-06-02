using System;
using System.Data;
using System.IO;
using SqlSugar;

namespace testdbspeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var connConfig = new SqlSugar.ConnectionConfig()
            {
                DbType = SqlSugar.DbType.SqlServer,         //必填, 数据库类型
                IsAutoCloseConnection = true,               //默认false, 时候知道关闭数据库连接, 设置为true无需使用using或者Close操作
                InitKeyType = InitKeyType.SystemTable,
                ConnectionString = "Data Source=192.168.100.14;Initial Catalog=LCCPWechat;Persist Security Info=True;User ID=cp;Password=Win2008"
            };
            var ss = new SqlSugar.SqlSugarClient(connConfig);

            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Restart();


            var json = ss.SqlQueryable<Lilly_DXY_Data_BgmBehavior>("select * from Lilly_DXY_Data_BgmBehavior_dxy").ToJson();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds / 1000.0);
            watch.Restart();
            //var json = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds / 1000.0);
            watch.Restart();

            using (StreamWriter sw  = new StreamWriter("/Users/tianjie/Lilly_DXY_Data_BgmBehavior.json"))
            {
                sw.Write(json);
            }
            //Tools.CSVHelper.WriteCSV("/Users/tianjie/Lilly_DXY_Data_BgmBehavior.csv", dataTable);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds/1000.0);
            
        }
    }
}
