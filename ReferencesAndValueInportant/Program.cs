using System;

namespace ReferencesAndValueInportant
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;// etsek number 2 ye tesir etmez referanslarda tesir eder misal

            string[] array1 = new string[3] { "1", "2", "3" };//misal ucun referansi 101

            string[] array2 = new string[3] { "1", "2", "3" };//misal ucun referansi 102

            string a = "aaa";
            string b = "aaa";

            if (a==b)
            {

                Console.WriteLine("esit");

            }
            else
            {
                Console.WriteLine("esit deil");
            }
            //eyer 
            array2 = array1; //edilerse array2 nin referansini array1in referansina beraberlesdirir
            array1[0] = "7";
            Console.WriteLine(array2[0]);
            Console.ReadLine();

            // Değişken türleri:  "int", "long", "float", "double",
            // "decimal", "char", "bool", "byte", "short", "struct", "enum"
            //Referans türleri:  "string", "object", "class",
            //"interface", "array", "delegate", "pointer

            //deyer tipler
            //referans tipler class,array,interfeysler
            //referanslar uzerinden islem yapiliyor
            //Bir referans türü olan string ile ilgili bu konuda önemli bir istisna vardır. string referans 
              //  türü olmasına rağmen metotlara geçirilirken değer tipiymiş gibi kopyalanırlar.

        }
    }
}
