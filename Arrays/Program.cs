using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] student1 = new string[3];  // bir boyutlu

            student1[0] = "bir";
            student1[1] = "bir";
            student1[2] = "bir";
            foreach (var student in student1)
            {
                Console.WriteLine(student);

            }

            int  [] numbers = new int[3] { 1, 2, 3 };

            string[] student2 = { "2", "3" };

            string[] student3 = { "2", "3" };

            string [,] regions = new string[2, 2]
            {
                {"istanbul","adana"},
                {"izmir","ankara" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);

                }

                Console.WriteLine("*************");
              
            }







            //if (student2 == student3)
            //{
            //    Console.WriteLine("esit");
            //}
            //else
            //{
            //    Console.WriteLine("esit deil");
            //}
            Console.ReadLine();
        }
    }
}
