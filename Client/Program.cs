using Domain;
using Domain.Entities;
using NHibernate.Criterion;
using Repositories;
using System;
using System.Linq;


namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sessionFactory = Configuration.CreateSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {

                        var storeRepository = new Repository<Store>(session);
                        var productRepository = new Repository<Product>(session);


                        var migros = new Store { Name = "Migros" };
                        var wallmart = new Store { Name = "Wallmart" };

                        storeRepository.Save(migros);
                        storeRepository.Save(wallmart);

                        
                        var potatoe = new Product { Name = "Potatoe", Price = 3.60 };
                        var fish = new Product { Name = "Fish", Price = 4.49 };
                        var milk = new Product { Name = "Milk", Price = 0.79 };

                        productRepository.Save(potatoe);
                        productRepository.Save(fish);
                        productRepository.Save(milk);

                        migros.Products.Add(potatoe);
                        migros.Products.Add(fish);
                        migros.Products.Add(milk);
                        
                        storeRepository.Save(migros);


                        wallmart.Products.Add(milk);
                        wallmart.Products.Add(fish);

                        storeRepository.Save(wallmart);


                        var daisy = new Employee { FirstName = "Daisy", LastName = "Harrison"};
                        var jack = new Employee { FirstName = "Jack", LastName = "Torrance"};
                        var sue = new Employee { FirstName = "Sue", LastName = "Walkters"};
                        var bill = new Employee { FirstName = "Bill", LastName = "Taft"};
                        var joan = new Employee { FirstName = "Joan", LastName = "Pope"};
                        var ciyat = new Employee { FirstName = "Ciyat", LastName = "Özpolat"};
                        var ozan = new Employee { FirstName = "Ozan", LastName = "Ertürk"};
               


                        migros.AddEmployee(jack);
                        migros.AddEmployee(jack);
                        migros.AddEmployee(sue);
                        migros.AddEmployee(bill);
                        migros.AddEmployee(joan);
                        wallmart.AddEmployee(ciyat);
                        wallmart.AddEmployee(ozan);
                     

                        storeRepository.Save(migros);


                        //var employee = session.QueryOver<Employee>().OrderBy(x => x.Salary).Asc.Take(1);
                        //Console.WriteLine(employee);
                        //Console.ReadKey();



                       // var list = session.QueryOver<Employee>().Fetch(x => x.Salary).OrderBy().Asc.ToList();

                      //  var sa = session.QueryOver<Employee>().Where(Restrictions.On<Employee>(c => c.Salary).);

                        transaction.Commit();

                    }

                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine(ex);
                        Console.ReadKey();

                    }
                    Console.ReadKey();
                }


            }
        }


    }

}
