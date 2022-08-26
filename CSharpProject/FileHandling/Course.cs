using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdoPractice
{
    class Course
    {
        public class Cour
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Fees { get; set; }
        }
        public class Program
        {
            static void WriteToFile(Cour cour)
            {
                try
                {
                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\TestFile", FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(cour.ID);
                    bw.Write(cour.Name);
                    bw.Write(cour.Fees);
                    bw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            static void ReadFromFile()
            {
                try
                {
                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\TestFile", FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    Console.WriteLine(br.ReadInt32());
                    Console.WriteLine(br.ReadString());
                    Console.WriteLine(br.ReadInt32());
                    br.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            static void Main(string[] args)
            {
                 Cour  cour = new Cour { ID = 1, Name = "CSharp", Fees = 25000 };
                 WriteToFile(cour);

                ReadFromFile();

               

            }

        }
    }
}
