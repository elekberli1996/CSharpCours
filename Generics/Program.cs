using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic kisitlari
            //belirli tiplerin yazilmasi ucun
            //meselen acnaq sinif yazila bilmesi ucun
            // where T:class  referans tip olmalidir boyle yazilanda string de yazila bilir cunki refeeans tip
            //fakat where T:class,new() hem referans tip olmali ve newlene bilmeli
            // where T:class,IEntity,new() hem referans tip hem IEntiden inpmlement olmali hem newlene bilmeli
            //where T:struct yanliz deyer tipler olur

            Utilities utilities = new Utilities();
            List<string> result = utilities.GetAll<string>("1", "2", "3");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> customers =
                utilities.GetAll<Customer>(new Customer { FirstName = "emin" }, new Customer { FirstName = "evez" });


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);

            }

            Console.ReadLine();
        }

        interface IProductDal : IRepository<Product>
        {
            //List<Product> GetAll();
            //Product Get();
            //void Add(Product product);

            //void Delete(Product product);

        }

        // bize lazim olan eyni kullanimlar icin generic isledirik
        //IRepositoryden inplment ede bilerik asagidaki kimi
        interface IRepository<T> where T:class,IEntity,new()
        {
            List<T> GetAll();
            T Get();
            void Add(T product);

            void Delete(T product);

        }
        interface IStudnetDal : IRepository<Customer>
        {

        }
        class CustomerDal
        {

        }
        interface IEntity { }

        interface ICustomerDal : IRepository<Customer>
        {
            //List<Customer> GetAll();
            //Customer Get();
            //void Add(Customer product);

            //void Delete(Customer product);
            void custom();

        }
        class Student : IEntity
        {

        }
        class Product : IProductDal,IEntity
        {
            public void Add(Product product)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product product)
            {
                throw new NotImplementedException();
            }

            public Product Get()
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }
        }

        class Utilities
        { 
            public List<T> GetAll<T>(params T [] deyerler)
            {
                return new List<T>(deyerler);
            }
        }


        class Customer :IEntity,ICustomerDal
        {
            public string FirstName { get; set; }
            public void Add(Customer product)
            {
                throw new NotImplementedException();
            }

            public void custom()
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer product)
            {
                throw new NotImplementedException();
            }

            public Customer Get()
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }
        }
    }
}
