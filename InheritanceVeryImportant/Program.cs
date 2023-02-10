using System;

namespace InheritanceVeryImportant
{
    class Program
    {
        static void Main(string[] args)
        {

            //kalitim
            //miras
           Person[] persons = new Person[3]
            {
                new Person(){ FirstName="emin"},
                new Student(){ FirstName="evez"},
            new Customer(){ FirstName="ilkane"}

            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);

            }


            Console.ReadLine();

            
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }

            public string LastName { get; set; }
        }


        //bir class 1 defa inherit yani miras ala birir
        //fakat coklu sayda inplemtsan ola biir interfyselrden farki

        // classlarin tek basina bir anlami vardir ancak interfeyslerin bir anlami yoktur
        class Customer : Person
        {
            public string City { get; set; }

        }

        class Student : Person
        {
            public int MyProperty { get; set; }
        }
    }
}
