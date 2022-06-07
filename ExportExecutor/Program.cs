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
            Console.WriteLine("Hello World1!");
            try
            {
                List<string> tables = new List<string>();
                Console.WriteLine("reading data.ls.");
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
                Console.WriteLine("Creating replace code");
                foreach (var tableName in tables)
                {
                    //tasks.Add(Export<Lilly_DXY_Data_Cards>(ak, sk, region, bucketName));
                    //###tableNames###
                    var codeLine = $"            tasks.Add(Export<{tableName}>(ak, sk, region, bucketName));\n";
                    codeToReplace += codeLine;
                }

                // 代码在/src目录下，需要到那边去修改和编译
                var totalCode = "";
                Console.WriteLine("Reading Export/Program.cs");
                using (StreamReader sr = new StreamReader("/src/Export/Program.cs"))
                {
                    totalCode = sr.ReadToEnd();
                }

                var newTotalCode = totalCode.Replace("//###tableNames###", codeToReplace);

                Console.WriteLine("Writing Export/Program.cs");
                using (StreamWriter sw = new StreamWriter("/src/Export/Program.cs", false))
                {
                    sw.Write(newTotalCode);
                }

                // 换代码完成，下面自动build那个Export工程， 并且自动启动这个工程的exe文件
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    WorkingDirectory = "/src/Export/",
                    FileName = "/usr/bin/dotnet",
                    Arguments = "build -c Release -o /publish/export"
                };
                Console.WriteLine("Building export solution");
                var p = Process.Start(startInfo);
                p.WaitForExit();//本行代码不是必须，但是很关键，限制等待外部程序退出后才能往下执行

                // 启动
                startInfo = new ProcessStartInfo()
                {
                    WorkingDirectory = "/publish/export",
                    FileName = "/usr/bin/dotnet",
                    CreateNoWindow = false,
                    Arguments = "Export.dll"
                };
                Console.WriteLine("Executing export solution");
                p = Process.Start(startInfo);
                //p.WaitForExit();//本行代码不是必须，但是很关键，限制等待外部程序退出后才能往下执行


                Console.WriteLine("Restore Export/Program.cs??? not executed in docker");
                //// 复原，以便下次使用
                //using (StreamWriter sw = new StreamWriter("Export/Program.cs", false))
                //{
                //    sw.Write(totalCode);
                //}

            }catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
