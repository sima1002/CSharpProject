using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdoPractice.LINQToObject
{
    class Product
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public int Price { get; set; }
        public string CompanyName { get; set; }

        public override string ToString()
        {
            return $"{ID}->{Name }->{Price}->{CompanyName}";
        }

    }
    class ProgramDemo
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product {ID =1,Name ="Mouse",Price =799,CompanyName ="Dell"},
                new Product {ID =2,Name ="Mouse",Price =699,CompanyName ="Lenovo"},
                new Product {ID =3,Name ="Laptop",Price =34799,CompanyName ="Dell"},
                new Product {ID =4,Name ="Laptop",Price =45799,CompanyName ="Sony"},
                new Product {ID =5,Name ="Laptop",Price =38799,CompanyName ="Lenovo"},
                new Product {ID =6,Name ="Keyboard",Price =599,CompanyName ="Dell"},
                new Product {ID =7,Name ="Keyboard",Price =999,CompanyName ="Mcrosoft"},
                new Product {ID =8,Name ="RAM 4GB",Price =2799,CompanyName ="Intel"},
                new Product {ID =9,Name ="Speaker",Price =5799,CompanyName ="Sony"},
                new Product {ID =10,Name ="USB Mouse",Price =1299,CompanyName ="Dell"}

            };






                   
                        var result1 =from p in products
                                     select p;


            var result2 = from p in products
                                      where p .Price <2000
                                      select p;

           

            var result3 = from p in products
                                      where p.Price < 2000 && p.Price<3000
                                      select p;


                        //var result4 = from p in products
                        //             where p.CompanyName.EndsWith("D")
                        //            select p;

                        // var result4 = from p in products
                        //               where p.CompanyName.StartsWith("o")
                        //               select p;

                        var result4 = from p in products
                                    where p.CompanyName.Contains("m")||p.CompanyName.Contains("M")
                                    select p;


                         var result5 = from p in products
                                      where p.Price<2500
                                      orderby p.Price descending
                                      select p;



            // Lambda expression
           
            var res1 = products.Where(p => p.Price < 2000).ToList();
           
            var res2 = products.Where(p => p.Price > 2000).OrderBy(x => x.Name).ToList();
           
            // retrive single record
            var res3 = products.Where(x => x.ID == 1).SingleOrDefault();
           
            var res4 = products.Where(x => x.Price < 2500).OrderBy(x => x.Price).ToList().Take(3);

            var res5 = products.Where(x => x.Price < 2500).OrderBy(x => x.Price).ToList().Take(3);

            var res6 = products.Where(x => x.Price < 2500).OrderBy(x => x.Price).ToList().Skip(3);


            foreach (Product item in res5)
                            {
                                Console.WriteLine(item);
                            }

            
        }
    }
}
