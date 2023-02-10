using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            // Console.WriteLine( Add2(2, 3));
            //Console.WriteLine(Add4(33));
            int a = 2;// ref keyvordde ilk deyer verilmeli
            int b = 3;
            int c; // out keyvordde ilk deyer verilmeyinin farki yok
            int d = 10;
            Console.WriteLine( Add5(ref a, b));
            Console.WriteLine(a);
            Console.WriteLine(Add6(out c, d));
            Console.WriteLine(a);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4,5));

            Console.WriteLine(Add7(1, 2, 3, 4, 5, 6, 7, 8));

            Console.WriteLine(Add8("emin", "elekberli"));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("addedi");
            
        }
        //void islem yap git sunu yap demek
        static int Add2(int a,int b)
        {
            var result = a + b;
            return result;
        }// deyer dondrumek istediyimiz zaman ne tip isteyirikse o tiple yazmaliyiz
        static string Add3(string a,string b)
        {
            return a + b;
        }

        static int Add4(int a, int b=30)
        {
            return a + b;
        }

        static int Add5(ref int a,int b)
        {
            a = 16;
            return a + b;
        }

        // ref keywodu ile referans tipler kimi deyer tipi deisdire bilerik
        //out
        //refin alternetivi out keyvordu mantik olarak aynisi farki refde
        //a yi set etmis olmaniz gerek deyeri olmali outda zorunluku yok

        //metodun icerisinde bi kere set edilmelidir outda
        static int Add6 (out int c, int d)
        {
            c = 16;
            return c + d;
        }

        // method overloading{

        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }

        // eyer 3 sayiyi vurmak istesek boyle yazilir overloading demekdir

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }

        static int Add7(int number1,params int[] numbers)


        {
            int a=number1;

            foreach (var item in numbers)
            {
                a= a * item;
            }
            return a;
        }

        static string Add8( params string[] musteriler )


        {
            string a = "";

            foreach (var item in musteriler)
            {
                a = a +" "+item;
            }
            return a;
        }

        //params birden cok deisken yazacayiqsa istfade edirik 
        //ayni mantik typscriptde restler olarak gecer
    }
}
