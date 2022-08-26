using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;


namespace AdoPractice.Serialization.HomeWork
{
   
        [Serializable]

        public class Product1
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int ProductPrice { get; set; }

        }

        public class XMLHo
    {
            static void XMLSerializationWrite(Product1 prc)
            {
                try
                {


                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\BinaryFile.xml", FileMode.Create, FileAccess.Write);
                    XmlSerializer xs = new XmlSerializer(typeof(Product1));
                    xs.Serialize(fs, prc); ;
                    Console.WriteLine("Binary data Added");
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
                     XmlSerializer xs = new XmlSerializer(typeof(Product1));
                     Product1 prc = (Product1)xs.Deserialize(fs);
                     Console.WriteLine(prc.ProductId);
                    Console.WriteLine(prc.ProductName);
                    Console.WriteLine(prc.ProductPrice);

                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }



            static void Main(string[] args)
            {


                Product1 prc = new Product1 { ProductId = 1225, ProductName = "BeautyProduct", ProductPrice = 1500 };
                XMLSerializationWrite(prc);

                XMLSerializationRead();
            }

        }
    
}
