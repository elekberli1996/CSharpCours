using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new DatabaseLogger();
            customerManager.logger2 = new FileLog();
            customerManager.Add();
            Console.ReadLine();
           
        }
        interface ILogger
        {
            void log();
        }

        class CustomerManager
        {
            public ILogger logger { get; set; }
            public ILogger logger2 { get; set; }
            public void Add()
                
            {
                logger.log();
                logger2.log();

                Console.WriteLine("added");
            }


        }
        class DatabaseLogger : ILogger
        {
            public void log()
            {
                Console.WriteLine("databasa loglandi");
            }
        }

        class FileLog : ILogger
        {
            public void log()
            {
                Console.WriteLine("file loglamada edildi");
            }
        }
    }
}
