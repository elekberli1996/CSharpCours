using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine(i);

            }
            int a = 10;
            while (a>0)
            {
                a=a-1;
                Console.WriteLine(a);
               

            }
            int x = 3;
            do
            {
                x--;
                Console.WriteLine(x);
            } while (x<0);

            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);

            }


            for (int c = 3; c < 10000; c++)
            {


                Console.WriteLine(c);
          
            for (int i = 2; i <= c/2; i++)
            {
                if (c % i == 0)
                {
                    Console.WriteLine("asal      sayi     deil");
                    break;
                }
                else if(c/2==i && c%i!=0){
                    Console.WriteLine("asal  sayyi");
                }
                
            }
                Console.WriteLine("**************");
            } Console.ReadLine();


        }
    }
}
