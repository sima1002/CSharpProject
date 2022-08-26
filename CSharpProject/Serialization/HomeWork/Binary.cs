using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace AdoPractice.Serialization.HomeWork
{
    
    
        [Serializable]

        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int ProductPrice { get; set; }

        }

        public class Binary
        {
            static void BinarySerializationWrite(Product prc)
            {
                try
                {


                    FileStream fs = new FileStream(@"E:\CSharpF\TestFolder\BinaryFile.dat", FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, prc);
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
                    Product prc = (Product)bf.Deserialize(fs);
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


                Product prc = new Product { ProductId = 1225, ProductName = "BeautyProduct", ProductPrice = 1500 };
                BinarySerializationWrite(prc);

                BinarySerializationRead();
            }

        }
    
}
