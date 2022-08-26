using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdoPractice
{
    class FileHandling_2
    {
        static void CreateFolder()
        {
            string path = @"E:\CSharpF\TestFolder";
            DirectoryInfo d = new DirectoryInfo(path);
            if (d.Exists )
            {
                Console.WriteLine("Folder is Already created");

            }
            else
            {
                d.Create();
                Console.WriteLine("Folder is created");
            }
        }

        static void CreateFile()
        {
            string path = @"E:\CSharpF\TestFolder\TestFile.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File is already exits");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File Created");

            }
        }
        static void Main(string[] args)
        {
            CreateFolder();
            CreateFile();
        }
    }
}
