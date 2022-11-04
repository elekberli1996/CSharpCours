using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

            Console.WriteLine(number == 10 ? "number is 10" : "10deil");

            if (number == 10)
            {
                Console.WriteLine(number);
                Console.ReadLine();

            }
            //ctrl k ctrl c ctrl k ctrl u comet etme cikma
            else if (number == 20)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("10 deil");
            }

            switch (number)
            {
                case 10:
                    Console.WriteLine("10"); break;
                case 20:
                    Console.WriteLine("10"); break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            if (true)
            {
                if (true)
                {

                }

            }


        }
    }
}
