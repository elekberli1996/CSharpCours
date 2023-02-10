using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action delegasyonu
            //metoda metot yollamak delegelerle gonderilir
            //cok dilde yoktur
            //ExceptionIntro();
            try
            {
                Find();// try can ile hatayi yakalayib istfadecye gosteriririk
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }

            HandleException(() =>
            {
                Find();
            });// metoda metod gondermimi


            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            //action metotda karsilik gelir
            try
            {
                action.Invoke(); 
                // parametre kimi gonderdiyimiz metodu bunun  icinde calistir demek
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "engin", "derin", "salih" };
            if (!students.Contains("ahmet"))  //ahmet yoksa hata firlat
            {
                throw new RecordNotFoundException("kayit bulunamadi");
                //kendin hatamizi firlatir ve sunucya mesaj verer

            }
            else
            {
                Console.WriteLine("record found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] array = new string[2] { "emin", "elekber" };
                array[3] = "i";


            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
