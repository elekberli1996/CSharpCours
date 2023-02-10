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

            string[] array2 = new string[3] { "4", "5", "6" };//misal ucun referansi 102

            //eyer 
            array2 = array1; //edilerse array2 nin referansini array1in referansina beraberlesdirir
            array1[0] = "7";
            Console.WriteLine(array2[0]);
            Console.ReadLine();


            //deyer tipler
            //referans tipler class,string,array,interfeysler
            //referanslar uzerinden islem yapiliyor

        }
    }
}
