using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace AdoPractice.Serialization.HomeWork
{
   
        [Serializable]

        public class Product2
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int ProductPrice { get; set; }

        }

        public class SOAPH
    {
            static void SOAPSerializationWrite(Product2 prc)
            {
                try
                {


                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\SoapFile.soap", FileMode.Create, FileAccess.Write);
                     SoapFormatter xs = new SoapFormatter();
                     xs.Serialize(fs, prc);
                     Console.WriteLine("Binary data Added");
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
                     Product2 prc = (Product2)xs.Deserialize(fs);
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


                Product2 prc = new Product2 { ProductId = 1225, ProductName = "BeautyProduct", ProductPrice = 1500 };
               SOAPSerializationWrite(prc);

              SOAPSerializationRead();
            }

        }
    
}
