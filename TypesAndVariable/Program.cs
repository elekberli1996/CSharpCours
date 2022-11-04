using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            
            /// Value Types
            int a = 18;//integer veri tipi sadece sayilari tutar  sinirlar 2milyar147milyon483647  //32 bit yer tutar
            long b = 10000000002; // imteger goture bilmediyi sayi long isledilir bellekde 2 kat yer tutar //19 karakterden ibaret /64bit yer tutar
            short c = 2; //16 bitlik yer tutar -32768 32767 araliginda tutar
            byte d = 255; // 0 la 255 araligi
            bool e = true; //dogru veya yanlis deyerlerin tutar
            char carakter = 'a'; //tek bir karakter tutar
            string city = "ankara";//yazilari tutar
            double f = 19.3;  //tam sayilardan farki olarak ondalikli sayilari tutar
            decimal t = 19.333333333333m;  //long neyse desimal odur , den sora 28 sonunan melave edilmelidir
            var number = 19;
            var st = "ffff";
            //varda veri nedirse o tipe doner
        // magic string eyer bi ifade 


            Console.WriteLine("number one is {0}",a);
            Console.WriteLine("number one is {0}", b);
            Console.WriteLine(Day.monday);
            Console.ReadLine();
        }
    }
    enum Day
    {monday,sunday,wednesday,thursday
    };
}
