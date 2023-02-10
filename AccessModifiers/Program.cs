using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        class Customer
        {
           int id; // default private olur private 
            //tanimlandigi blok icinde gecerlidir

            protected int id2 { get; set; }

            //privatenin ozelliklerini tasir
            //prodtected inherit edildiyi sinifada ulasila bilir
        }

        class Student:Customer
        {
            public void Save()
            {
                id2 = 10; 
                

            }
            
        }
        class Course
        { 
            // clasin defaultu internal dir
            // bagli bulundugu projede refernans itiyaci olmadan kullanila bilir

            // bi class private olamaz protected da olamaz
            //ya public yada internal olur
            //internnal movcut projede kullanilir

            //public referans verildiyinde baska projedede kullanilir internaal ile olmur






            public int MyProperty { get; set; }
        }
    }
}
