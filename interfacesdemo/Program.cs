using System;

namespace interfacesdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] worker = new IWorker[3]
            {
                new Worker(),
                new Robot(),
                new Manager()
            };

            IEater[] eaters = new IEater[2]
            {
                new Manager(),
              new Worker()
            };

            foreach (var work in worker)
            {
                work.Work();

            }
            foreach (var eat in eaters)
            {
                eat.Eat();

            }
          

            Calistir calistir = new Calistir();

            calistir.work(new Robot());
            //  calistir.eat(new Robot()); //olmaz
            //calistir.salary(new Robot()); //olmaz


            calistir.work(new Worker());
            calistir.eat(new Worker());
            calistir.salary(new Worker());

            calistir.work(new Manager());
            calistir.eat(new Manager());
            calistir.salary(new Manager());
            Console.ReadLine();        

        }

        interface IWorker
        {

            void Work();

        }
        interface IEater
        {

            void Eat();

        }
        interface ISalary
        {

            void Salary();

        }

        class Manager : IWorker, IEater, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("manager yedi");
            }

            public void Salary()
            {
                Console.WriteLine("manager maas aldi");
            }

            public void Work()
            {
                Console.WriteLine("manager calisdi");
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("robot calisdi");
            }
        }
        class Worker : IWorker, IEater, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("calisan yedi");
            }

            public void Salary()
            {
                Console.WriteLine("calian maas aldi");
            }

            public void Work()
            {
                Console.WriteLine("calisan calisdi");
            }


        }
        class Calistir
        {
            public void work(IWorker worker)
            {
                worker.Work();
            }
            public void eat(IEater eater)
            {
                eater.Eat();
            }

            public void salary(ISalary salary)
            {
                salary.Salary();
            }

        }
    }
}
