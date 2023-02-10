using System;
using System.Data;
using System.Data.SqlClient;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "my name is emin elekberli";

            var result = sentence.Length;

            var result2 = sentence.Clone(); // bir tane dahah ayni deisken olustururuz

            bool result3 = sentence.EndsWith("i"); // cumle sonu i yle bitermi

            bool restlt4 = sentence.StartsWith("m");// cumle m ile baslarmi;

            var result5 = sentence.IndexOf("name"); // hansi indeksden baslir onu tapir eyer bulmazsa -1 doner

            var result6 = sentence.IndexOf(" "); // buldugu ilk boslugu bular sonrani saymaz

            var result7 = sentence.LastIndexOf(" "); // aramaya sondan baslar indeks of basdan baslar

            var result8 = sentence.Insert(0, "helloo"); // metnin her hangi bi yerine ekleme yapmak

            var result9 = sentence.Substring(3,7); // metni parcalamak icin start indeksden baslar 3 cu karakterden 4 tane al

            var rsult10 = sentence.ToLower(); // butun karakterler balaca

            var result11 = sentence.ToUpper(); // buyuk karakter yapar

            var result12 = sentence.Replace(" ", "-"); //bosluk name yerine - yazar

            var result14 = sentence.Remove(3);// 3 cu karakterden sorani silmek ucundur

            var result15 = sentence.Remove(3,3);// 3 cu karakterden 3 karakter silmek ucundur


            Console.WriteLine(result15);

            









            //string city = "ankara";
            //string city2 = "istanbul";




            //Console.WriteLine(String.Format("{0} {1}", city, city2));
            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
       
    }
}
