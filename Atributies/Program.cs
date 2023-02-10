using System;

namespace Atributies
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "demirog", Age = 12 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
        [toTable("Customers")]
        [toTable("sCustomers")]

        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty] //atributlar boyle yazilir bi atrubut qoyuruqki zorumlu olsun girilmesi
            public string FirstName { get; set; }
            [RequiredProperty]
          
            public string LastName { get; set; }
            [RequiredProperty]
            public int Age { get; set; }
        }
        class CustomerDal
        {
            //hazir atributlarda var meselen uyari ucun eski demek
            [Obsolete("arkadas bunu kullanma AddNew Kullan")]
            public void Add(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }

            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }


        }
        //atibita da atribut eklemek olar meselen harda kullana bilerik
        //[AttributeUsage(AttributeTargets.All)]//her yerde kullana biler
        [AttributeUsage(AttributeTargets.Property |AttributeTargets.Field,AllowMultiple =false ) ]//propertler nesneler kullanir
        //pipe sayesinde birden fazla target eklemekolar
        //AllowMultiple=true 1den fazla ukllana bileri yada falsa ile kullanamariq
        class RequiredPropertyAttribute : Attribute
        {

        //kendi atributlaerimizi yazariq reflectionlar sayesinde ilerki dersde gorecyik
        }
        [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]//calsslarda kullanilir
        class toTableAttribute : Attribute
        {
            private string _deyer; //atribute deyer yollamak
            public toTableAttribute(string deyer)
            {
                _deyer = deyer;

            }
        }
    }
}
