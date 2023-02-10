using System;

namespace InterfacesImportantSignificant
{
    class Program
    {
        static void Main(string[] args)
        {
            //inteface1();
            //interfaces2();

            //bir interfeys hec bir zaman new lenemez

            //polimorfizm cokbicimlik bir nesneyi farki amaaclarla impementlerle implemente edmek
            // interfaces2();
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
               new SqlCustomerDal(),
               new OracleCustomerDal(),
                new MySqlCustomerDal()
            };


            foreach (var customerDal in customerDals)
            {
                customerDal.Add();

            }
            Console.ReadLine();
        }

        private static void interfaces2()
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new SqlCustomerDal());
            customerManager.Delete(new SqlCustomerDal());

            customerManager.Add(new OracleCustomerDal());
            customerManager.Delete(new OracleCustomerDal());
        }

        private static void inteface1()
        {
            PersonManager personManager = new PersonManager();

            personManager.Add(new Customer { Id = 1, FirstName = "emin", LastName = "elekberli", Adress = "nahcivan" });

            Student student = new Student
            {
                FirstName = "evez",
                LastName = "elekberli",
                Id = 1,
                Number = 111
            };
            personManager.Add(student);



            personManager.Add(new Customer { Id = 1, FirstName = "emin", LastName = "elekberli", Adress = "nahcivan" });

            
        }

        interface IPerson
        {
             int Id{ get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get ; set; }
            public string LastName { get ; set ; }
            public string Adress { get; set; }
        }

        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int Number { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson customer)
            {
                Console.WriteLine(customer.FirstName + " Eklendi");
            }

        }
    }
}
