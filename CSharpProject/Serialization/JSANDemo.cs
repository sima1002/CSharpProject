using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;


namespace AdoPractice.Serialization
{

    [Serializable]

    public class Student1
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

    }

    public class JSANDemo
    {
        static void JSONSerializationWrite(Student1 stud)
        {
            try
            {


                FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Student1>(fs, stud);

                Console.WriteLine("Data Added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void JSONSerializationRead()
        {
            try
            {


                FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\JsonFile.json", FileMode.Open, FileAccess.Read);
                Student1 stud = JsonSerializer.Deserialize<Student1>(fs);

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


            Student1 stud = new Student1 { RollNo = 101, Name = "Ojasvi", Percentage = 97.67 };
            JSONSerializationWrite(stud);
            JSONSerializationRead();
            


         }
    }
}
