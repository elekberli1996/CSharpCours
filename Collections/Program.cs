using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
           // string[] cities = new string[2] { "ankara", "istanbul" };
            // yeni eleman eklemek problemdir

            // colleksyonlardan istifade edmliyik

            // en temel kolleksyoon ArrayList lerdir
            ArrayLst();

            //generic kolleksyonlar

            List<string> cities = new List<string>();
            cities.Add("istanbul");
            cities.Add("adana");
           // cities.Add(1); bunu kabul etmez
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            var pers = new Person { Id = 4, FirstName = "inci" };
            //daha profosyinel kullanim
            List<Person> persons = new List<Person>();
            persons.Add(new Person { Id = 1, FirstName = "emin" });
            persons.Add(new Person { Id = 2, FirstName = "evez" });
            persons.Add(new Person { Id = 2, FirstName = "evez" });

            var count = persons.Count;// kac elemanli kolleksyon
            Console.WriteLine("count:{0}",count);
            persons.Add(pers); //yeni eleman ekler

            persons.AddRange(new Person[2]{ //aray seklinde ekleme yapar
            new Person{Id=5,FirstName="gulxar"},
            new Person{Id=4,FirstName="melek"}
            });
            //persons.Clear();// listeyi temizler elemanlari siler
            persons.IndexOf(pers); // bu elemanin kacinci indeksde oldugunu gosterir
            persons.LastIndexOf(pers);// aramaya sondan baslar
            persons.Insert(0, pers);// hansi indekse eklenme istesek ora ekleriz istediyimiz indekse ekler
            //diyerlerin kaydirir
            persons.Remove(pers);//  buldugu ilk deyeri siler ve bititir
            persons.RemoveAll(c => c.FirstName == "melek");//hepsini siler

            var d=persons.Contains(pers);// listede aranan deyer varmi true false dondurur
            Console.WriteLine(d);
            foreach (var person in persons)
            {

                Console.WriteLine(person.FirstName);

            }

            List<Person> p1 = new List<Person>
            {
                new Person{Id=1,FirstName="ilkane"},
                new Person{Id=2,FirstName="ec="}

            };

            foreach (var p in p1)
            {
                Console.WriteLine(p.Id);

            }

            //dictionary kolleksyonu

            Dictionary<int, string> values = new Dictionary<int, string>();
            //bi liget kimi dusunmek olar her bir kelimeye bi cavap karsilik gelir 
            values.Add(1, "ankara");
            values.Add(2, "adana");
            values.Add(3, "edirne");

            Console.WriteLine(values[1]);

            foreach (var value in values)
            {
                Console.WriteLine(value);
                Console.WriteLine(value.Key);//anahtar deyer
                Console.WriteLine(value.Value);// anahtara karsilik deyer
            }

            Console.WriteLine(values.ContainsKey(1)); // bu anahtar deyeri varmi yokmu
            Console.WriteLine(values.ContainsKey(5));









            Console.ReadLine();
        }

        private static void ArrayLst()
        {
            ArrayList citi = new ArrayList();
            citi.Add("ISTANBUL");
            citi.Add("ANKARA");
            citi.Add(1);
            foreach (var item in citi)
            {
                Console.WriteLine(item);
            }
            citi.Add(1);
            Console.WriteLine(citi[2]);
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }
    }
}
