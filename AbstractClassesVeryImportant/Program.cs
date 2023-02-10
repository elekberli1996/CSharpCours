using System;

namespace AbstractClassesVeryImportant
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract class tamamlanmis ve tamamlanmis metodlarlar icerir
            //virtual ile interfeysin birlesimi kimi

            // ici dolu olmayan virtual metoddur

            // abstarct classlarda interfeys kimi new lene bilmir

            Database database = new Sql();
            database.Add();
            database.delete();
            Database database1 = new Oracle();
            database1.Add();
            database1.delete();
            Console.ReadLine();

        }

        abstract class Database
        {
            public void delete()
            {
                Console.WriteLine("basadan silindi");
            }
             public abstract void Add();
        }

        class Sql : Database
        {
            public override void Add()
            {
                Console.WriteLine("added by sql");
            }
        }

        class Oracle : Database
        {
            public override void Add()
            {
                Console.WriteLine("added by oracle");
            }
        }
    }
}
