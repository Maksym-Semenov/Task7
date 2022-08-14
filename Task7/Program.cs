using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Part 1
            //string oldPath = @"D:\data.txt";
            //string newPath = @"D:\rez.txt";
            //string path = @"D:\rez2.txt";
            //string temp = "";
            //try
            //{
            //    using (StreamReader sr =
            //        new StreamReader(oldPath))
            //    {
            //        temp = sr.ReadToEnd();
            //        Console.WriteLine(temp);
            //    }
            //    using (StreamWriter sw = new StreamWriter(newPath, true))
            //    {
            //        sw.WriteLine(temp);
            //    }
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File not found");
            //}
            //catch (FileLoadException)
            //{
            //    Console.WriteLine("File do not loaded");
            //}
            //File.WriteAllText(path, temp);

            //Console.ReadLine();

            ////Part 2
            //try
            //{
            //    string dirName = @"D:\";
            //    if (Directory.Exists(dirName))
            //    {
            //        string[] directories = Directory.GetDirectories(dirName);
            //        foreach (var dir in directories)
            //        {
            //            Console.WriteLine(dir);
            //        }
            //    }
            //}
            //catch (DirectoryNotFoundException)
            //{
            //    Console.WriteLine("Directory not found");
            //}
            //Console.ReadLine();
            //Part 3

            DirectoryInfo oldDir = new DirectoryInfo(@"D:\Task7");
            DirectoryInfo newDir = new DirectoryInfo(@"D:\Task8");
            FileInfo[] files = oldDir.GetFiles();
            int a = files.Count();
            FileInfo[] filesTXT = new FileInfo[a];
            int j = 0;
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Extension == ".txt")
                {
                    filesTXT[j] = files[i];
                    j++;
                }
            }
            Console.ReadLine();
            //FileInfo fileInfo = new FileInfo(path);
            //if (fileInfo.Exists)
            //{
            //    Console.WriteLine($"File name:\t", fileInfo.Name);
            //    Console.WriteLine($"File create:\t ", fileInfo.CreationTime);
            //    Console.WriteLine($"File foolname:\t ", fileInfo.FullName);
            //    Console.WriteLine($"File lenght:\t ", fileInfo.Length);
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File not found"); ;
            //}
            //catch (FileLoadException)
            //{
            //    Console.WriteLine("File not loaded");

        }
    }
}
