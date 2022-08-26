using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;




namespace AdoPractice.Serialization
{
   

        [Serializable]

        public class Student2
        {
            public int RollNo { get; set; }
            public string Name { get; set; }
            public double Percentage { get; set; }

        }

        public class XMLSeriaDemo
        {
            static void XMLSerializationWrite(Student2 stud)
            {
                try
                {


                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\BinaryFile.xml", FileMode.Create, FileAccess.Write);
                    XmlSerializer xs = new XmlSerializer(typeof(Student2));
                    xs.Serialize(fs, stud);
                    Console.WriteLine(" data Added");
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            static void XMLSerializationRead()
            {
                try
                {


                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\BinaryFile.xml", FileMode.Open, FileAccess.Read);
                    XmlSerializer xs = new XmlSerializer(typeof(Student2));
                    Student2 stud = (Student2)xs.Deserialize(fs);
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


                Student2 stud = new Student2 { RollNo = 101, Name = "Ojasvi", Percentage = 97.67 };
                XMLSerializationWrite(stud);

                XMLSerializationRead();
            }

        }

    
}
