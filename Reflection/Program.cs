using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DordIslem dordIslem = new DordIslem(2, 3);
            //dordIslem.carp();
            //dordIslem.carp2(4, 5);
            // run ttime zamani her hansi bir nesne hakkinda bilgi toplaya biliriz
            //bilgi toplamak ozellikleri atributu deyerleri varmi
            // o metodu calistira biliriz
            // bri kullanici icin hangi nnesnenin metodun uygulama gidisatina gore ne yapmaq gerek karar verile biler
            var type = typeof(DordIslem); // butun tipleri handle ede bildiyimiz ataya bildiyimiz metod
            

           DordIslem dordislem= (DordIslem) /*cast*/ Activator.CreateInstance(type,33,4);
            //activator sinifi bi instanse yansima yapib new leme kimi edirik
           // Console.WriteLine( dordislem.carp2(3, 4));
          //  Console.WriteLine(dordislem.carp());
           

            //Metod Info Invoke
            var instance = Activator.CreateInstance(type, 32, 3);
            //getmethod ile istediyimiz metoda ulasirqi invoke ile onu calistiriz
            MethodInfo methodInfo = instance.GetType().GetMethod("carp");
          
            Console.WriteLine(  methodInfo.Invoke(instance, null)  );
            Console.WriteLine(  instance.GetType().GetMethod("carp2").
                Invoke(instance,/*consturctora bele paramaetre yollayiriq*/new Object[] {2,3 }));

            //Nesneye aid ozelliklere liste sekilde ulasmak
            Console.WriteLine("-----------------");

            var metodlar = type.GetMethods();// metodlara ulasiriq
            foreach (var info in metodlar)
            {
                Console.WriteLine("METOD ADI : {0}", info);
                foreach (var p in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", p);
                    //parametrelerne ulasa bilerik

                }

                foreach (var at in info.GetCustomAttributes())
                {
                    Console.WriteLine("Atribute : {0}", at.GetType().Name);
                    //atributlara ulasa  bilerik
                }



            }

      




 Console.ReadLine();

        }
        class MetodNameAttribute : Attribute
        {

        }


        class DordIslem
        {
            private int _deyer1;
            private int _deyer2;
            
            public DordIslem(int deyer1,int deyer2)
            {
                _deyer1 = deyer1;
                _deyer2 = deyer2;

            }

            public int topla1()
            {

                return _deyer1 + _deyer2;
            }
            [MetodName]
            public int carp()
            {
                return _deyer1 * _deyer2;
            }

            public int topla2(int deyer1,int deyer2)
            {
                return deyer1 + deyer2;
            }
            public int carp2(int deyer1,int deyer2)
            {
                return deyer1 * deyer2;
            }

        }
    }
}
