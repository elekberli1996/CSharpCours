using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // bir klas new edildiyinde calisan kod blokudur
            CustomerManager customerManager = new CustomerManager(33);
            customerManager.add();
            Product product = new Product();
            Product product1 = new Product(1, "emin");
            EmployeManagment employeManagment = new EmployeManagment(new DatabaseLogger());
            employeManagment.Add();

            Motor motor = new Motor("mehraba");
            motor.Add();
            Utilities.validate();// static class cagirimiriq

            Console.ReadLine();
        }

        class CustomerManager
        {
            int _count=18;
            public CustomerManager(int count)
            {
                 _count = count;
            }

            public CustomerManager()
            {
                //overloading
            }
            public void add()
            {
                Console.WriteLine( "sayi = {0}",_count);
            }

            public void list()
            {

            }
        }

        class Product
        {

            public int Id { get; set; }
            public string Name { get; set; }

            public Product()
            {

            }

            private int _Id;
              
                private string _Name;

            public Product(int id,string name)
            {
                _Id = id;
                _Name = name;

            }


        }
        interface ILogger
        {
            void log();
        }

        class DatabaseLogger : ILogger
        {
            public void log()
            {
                Console.WriteLine("databaze loged added");
            }
        }
        class FileLogger : ILogger
        {
            public void log()
            {
                Console.WriteLine("fill loged added");
            }
        }
        class EmployeManagment
        {
            private ILogger _logger;

            public EmployeManagment(ILogger logger)
            {
                _logger = logger;
            }
            public void Add()

            {
                _logger.log();
               // Console.WriteLine("aadddeedd");
            }
        }


        class Araba
        {
            private string _mesaj;
            public Araba(string mesaj)
            {
                _mesaj = mesaj;
            }

            public void calistir()
            {
                Console.WriteLine(_mesaj);
            }
        }

        class Motor : Araba
        {
            public Motor(string mesaj):base(mesaj)
            {
              // inherit edilen classda conrtructor varsa parametreli
              // bu klasdan parametre gondermeliyik
            }
            public void Add()
            {
                calistir();
            }

            
            

            
        }

        static class Utilities
        { 
            //static classlar newlene bilmir

            //static bir sinifin her seyi static olur
            // clasda static metod ola biler
            public static void validate()
            {

            }
        }


    }
}
