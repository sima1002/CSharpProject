using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdoPractice.LINQToObject
{
    
        public class Emp
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public string City { get; set; }
            public override string ToString()
            {
                return $"{ID} {Name} {Salary} {City} ";
            }
        }

       class Employee
       {
                static void Main(string[] args)
                {

            List<Emp> e = new List<Emp>()
            {
                new Emp {ID =1,Name ="Mohit",Salary =17000,City  ="Pune"},
                new Emp {ID =2,Name ="Riya",Salary =26000,City ="Nashik"},
                new Emp  {ID =3,Name ="Jay",Salary =34799,City ="Mumbai"},
                new Emp  {ID =4,Name ="Rahul",Salary =45799,City="Solapur"},
                new Emp  {ID =5,Name ="Latika",Salary =38799,City ="Amravati"},
                new Emp {ID =6,Name ="Kedar",Salary =55000,City ="Pune"},
                new Emp {ID =7,Name ="Krish",Salary =45000,City ="Mumbai"},
                new Emp {ID =8,Name ="Rohan",Salary =27000,City ="Nashik"},
                new Emp {ID =9,Name ="Simaran",Salary =34000,City ="Solapur"},
                new Emp{ID =10,Name ="Uma",Salary =12000,City ="Pune"}

            };


                                  //   1.display all employees
                                     var result1 = from s in e
                                                    select s;
                                  //  Lambda
                                     var res1 = e.ToList();


           
                                   //  2.display employee with asending order by name
                                      var result2 = from s in e
                                                    orderby s.Name 
                                                    select s;
                                   //  Lambda
                                        var res2 = e.OrderBy(x => x.Name).ToList();

            
            
                              //  3.display employee whose salary is > 25000
                                        var result3 = from s in e
                                                     where s.Salary >25000 
                                                     select s;
                               //  Lambda
                                        var res3 = e.Where(p => p.Salary > 25000).ToList();

           
            
                               //  4.display employee whos from 'Pune' City
                                        var result4 = from s in e
                                                    where s.City.Contains("Pune")
                                                    select s;
                                 //  Lambda
                                         var res4 = e.Where(x => x.City == "Pune").ToList ();

           
            
                              //  5.display employee with desending order by salary
                                            var result5 = from s in e
                                                        orderby s.Salary descending
                                                        select s;
                              //  Lambda
                                  var res5 = e.OrderByDescending(p =>p.Salary).ToList();

           
            
            
                              //  6. display employee whose name start with 'P'
                                            var result6 = from s in e
                                                        where s.Name.StartsWith("K")
                                                        select s;
                              //  Lambda

                                     var res6 = e.Where(x => x.Name.StartsWith ("K")).ToList();

            
            
            
                              //   7. display employee whose salary is > 25000 & emp is from 'Mumbai' city
                                            var result7 = from s in e
                                                         where s.Salary>25000 && s.City .Contains("Mumbai")
                                                         select s;
                              //  Lambda
                                    var res7 = e.Where(p => p.Salary > 25000).OrderBy(x => x.City ="Mumbai").ToList();





                            foreach (Emp  i in res2)
                            {
                                     Console.WriteLine(i);
                            }

                }

       }
}
