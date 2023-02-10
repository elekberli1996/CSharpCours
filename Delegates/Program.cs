using System;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();
        // delege tanimi void olan parametresi olmayan metodlara delegelik yapiyor

        public delegate void MyDelegate1(string text);
        //void olan string parametre alan metodlara hizmet eden delege
        //delegede nece metod varsa hepsine ayni parametre yollar

        public delegate int MyDelegate2(int sayi1, int sayi2);
        //return donduren parametre alan metodlara delegelik yapar
        static void Main(string[] args)
        {
            //  delege-elci
            CustomerManager customerManager = new CustomerManager();

            MyDelegate myDelegate = customerManager.SendMesage;
            myDelegate += customerManager.ShowAlert;
            //
            myDelegate -= customerManager.ShowAlert;

            MyDelegate1 myDelegate1 = customerManager.SendMesage2;
            myDelegate1 += customerManager.ShowAlert2;
            myDelegate1("helloo");

            myDelegate();

            Matamatik matamatik = new Matamatik();

            MyDelegate2 myDelegate2 = matamatik.topla;

            myDelegate2 += matamatik.carp;

            // delegede return varsa en son return type varsa es sonuncunu calsitriacaktir

            Console.WriteLine( myDelegate2(3, 4));

            //action void metodlar ucun
            //func ise donus tipi olan parametreler icin kullanislidir
            Console.WriteLine("***********");
            Func<int, int, int> add = topla;
            Console.WriteLine(add(3, 3));

            Func<int> randomSayi1 = delegate ()
            {
                Random randomSayi = new Random();
                return randomSayi.Next(2, 44);
            };

            Func<int> randomSayi2 = () =>
            {
                return new Random().Next(2, 34);
            };
            Console.WriteLine(randomSayi1());
            Console.WriteLine(randomSayi2());

            Console.ReadLine();

            
        }
        static int topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public class CustomerManager
        {
            public void SendMesage()
            {
                Console.WriteLine("hello");
            }

            public void ShowAlert()
            {
                Console.WriteLine("be caeful");
            }
            public void SendMesage2(string mesaj)
            {
                Console.WriteLine(mesaj);
            }

            public void ShowAlert2(string alert)
            {
                Console.WriteLine(alert);
            }
        }

        public class Matamatik
        {
            public int topla(int sayi1,int sayi2)
            {
                return sayi1 + sayi2;
            }
            public int carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }

        }

    }
}
