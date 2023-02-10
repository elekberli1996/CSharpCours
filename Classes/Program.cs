using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();

            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "emin";
            customer.LastName = "elekberli";
            customer.City = "naxcivan";

            Customer customer2 = new Customer()
            {
                Id = 2,City="naxcivan",FirstName="evez",LastName="elekberli"

            };

            Customer customer3 = new Customer()
            {
                Id = 3,
                City = "naxcivan",
                FirstName = "evez",
                LastName = "elekberli"

            };

            Console.WriteLine(customer3.FirstName);



            Console.ReadLine();
            
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("customer added");
        }

        public void Update()
        {
            Console.WriteLine("costomer guncellendi");
        }

    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("customer added");
        }

        public void Update()
        {
            Console.WriteLine("costomer guncellendi");
        }

    }

}
