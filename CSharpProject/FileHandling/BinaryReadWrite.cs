using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdoPractice
{
    class BinaryReadWrite
    {
        public class Dept
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
        }
        public class Program
        {
           static void WriteToFile(Dept dept)
            {
                try
                {
                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\TestFile", FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(dept.ID);
                    bw.Write(dept.Name);
                    bw.Write(dept.Location);
                    bw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            static void  ReadFromFile()
            {
                try
                {
                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\TestFile", FileMode.Open, FileAccess.Read );
                    BinaryReader br = new BinaryReader(fs);
                    Console.WriteLine(br.ReadInt32());
                    Console.WriteLine(br.ReadString());
                    Console.WriteLine(br.ReadString());
                    br.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void Main(string[]args)
            {
                //  Dept dept = new Dept { ID = 1, Name = "HR", Location = "Pune" };
                // WriteToFile(dept);

                ReadFromFile();

            }


        }
    }



    class UserThrough
    {
        //Write a code to accept string from user & write to file using StreamWriter & read & display on console
        static void Writeusingstream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:C#TestFolder estfile", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(Console.ReadLine());
                sw.Close();
                fs.Close();
                Console.WriteLine("done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ReadUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:C#TestFolder estfile", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        static void Main(string[] args)
        {
            //Writeusingstream();
            ReadUsingStream();
            Console.ReadLine();
        }
    }
}
