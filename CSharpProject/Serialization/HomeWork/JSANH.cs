using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;


namespace AdoPractice.Serialization.HomeWork
{
    
        [Serializable]

        public class Product3
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int ProductPrice { get; set; }

        }

        public class JSANH
        {
            static void JSONSerializationWrite(Product3 prc)
            {
                try
                {


                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                    JsonSerializer.Serialize<Product3>(fs, prc);
                    Console.WriteLine("Binary data Added");
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
                   Product3 prc = JsonSerializer.Deserialize<Product3>(fs);
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


                Product3 prc = new Product3 { ProductId = 1225, ProductName = "BeautyProduct", ProductPrice = 1500 };
               JSONSerializationWrite(prc);

                JSONSerializationRead();
            }

        }
    
}
