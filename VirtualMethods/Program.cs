using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            // inherit edilen ortamda bir cok ortamda ayni olan metodu
            // eze bilmek ucun ozumuz yaza bilmek ucun virtual isledilir

            // virtual =>override islemi ucun

            Sql sql = new Sql();
            sql.Add();
            MySql mySql = new MySql();
            mySql.Add();



            Console.ReadLine();

           
        }




        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("add by defaultt");
               
            }
            public virtual void Delete()
            {
                Console.WriteLine("delete by default"); 
            }
        }


        class Sql : Database
        {
            public override void Add()
            {
                Console.WriteLine("added by sql");
                //base.Add(); //default
            }
           
        }

        class MySql : Database
        {
            public override void Delete()
            {
                base.Delete();
            }
        }






    }
}
