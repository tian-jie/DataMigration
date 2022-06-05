using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ExportExecutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> tables = new List<string>();
            using (StreamReader sr = new StreamReader("data.ls"))
            {
                while (!sr.EndOfStream)
                {
                    var l = sr.ReadLine();
                    if (!string.IsNullOrEmpty(l))
                    {
                        tables.Add(l);
                    }
                }
            }

            var codeToReplace = "";
            foreach(var tableName in tables)
            {
                //tasks.Add(Export<Lilly_DXY_Data_Cards>(ak, sk, region, bucketName));
                //###tableNames###
                var codeLine = $"            tasks.Add(Export<{tableName}>(ak, sk, region, bucketName));\n";
                codeToReplace += codeLine;
            }

            var totalCode = "";
            using(StreamReader sr = new StreamReader("Export\\Program.cs"))
            {
                totalCode = sr.ReadToEnd();
            }

            var newTotalCode = totalCode.Replace("//###tableNames###", codeToReplace);

            using (StreamWriter sw = new StreamWriter("Export\\Program.cs", false))
            {
                sw.Write(newTotalCode);
            }

            // 换代码完成，下面自动build那个Export工程， 并且自动启动这个工程的exe文件
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                WorkingDirectory = "export\\",
                FileName = "dotnet.exe",
                Arguments = "build -c Release"
            };
            var p = Process.Start(startInfo);
            p.WaitForExit();//本行代码不是必须，但是很关键，限制等待外部程序退出后才能往下执行

            // 启动
            startInfo = new ProcessStartInfo()
            {
                WorkingDirectory = "export\\bin\\Release\\net5.0\\",
                FileName = "Export.exe",
                CreateNoWindow = false,
                Arguments = ""
            };
            p = Process.Start(startInfo);
            //p.WaitForExit();//本行代码不是必须，但是很关键，限制等待外部程序退出后才能往下执行


            // 复原，以便下次使用
            using (StreamWriter sw = new StreamWriter("Export\\Program.cs", false))
            {
                sw.Write(totalCode);
            }
            

        }
    }
}
