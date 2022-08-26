using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace AdoPractice.Serialization
{
   
        [Serializable]

        public class Student
        {
            public int RollNo { get; set; }
            public string Name { get; set; }
            public double Percentage { get; set; }

        }

    public class SOAPDemo
    {
        static void SOAPSerializationWrite(Student stud)
        {
            try
            {


                FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\SoapFile.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter xs = new SoapFormatter();
                xs.Serialize(fs, stud);
                Console.WriteLine(" data Added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SOAPSerializationRead()
        {
            try
            {


                FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\SoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter xs = new SoapFormatter();
                Student stud = (Student)xs.Deserialize(fs);
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


                Student stud = new Student { RollNo = 101, Name = "Ojasvi", Percentage = 97.67 };
                SOAPSerializationWrite(stud);
                SOAPSerializationRead();
            }


        

    }
}
