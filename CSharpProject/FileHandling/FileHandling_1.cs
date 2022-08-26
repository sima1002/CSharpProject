using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace AdoPractice
{
    class FileHandling_1
    {
        static void CreateFolder()
        {
            string path = @"E:\CSharpF\TestFolder";
            if(Directory.Exists(path))
            {
                Console.WriteLine("Folder is Already created");

            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Folder is created");
            }
        }

        static void CreateFile()
        {
            string path = @"E:\CSharpF\TestFolder\TestFile.txt";
            if(File.Exists (path ))
            {
                Console.WriteLine("File is already exits");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File Created");

            }
        }
        static void Main(string[]args)
        {
            CreateFolder();
            CreateFile();
        }
    }
}
