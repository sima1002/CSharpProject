using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;



namespace AdoPractice.Serialization

{
   
        [Serializable]

        public class Student3
        {
            public int RollNo { get; set; }
            public string Name { get; set; }
            public double Percentage { get; set; }

        }

        public class BinarySeriDemo
    {
            static void BinarySerializationWrite(Student3 stud)
            {
                try
                {


                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\BinaryFile.dat", FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, stud);
                    Console.WriteLine("Binary data Added");
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            static void BinarySerializationRead()
            {
                try
                {


                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\BinaryFile.dat", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    Student3 stud = (Student3)bf.Deserialize(fs);
                    Console.WriteLine(stud.RollNo);
                    Console.WriteLine(stud.Name);
                    Console.WriteLine(stud.Percentage);

                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


      
            static void Main(string[] args)
            {


                Student3 stud = new Student3 { RollNo = 101, Name = "Ojasvi", Percentage = 97.67 };
                BinarySerializationWrite(stud);

                BinarySerializationRead();
            }

        }
    
}
