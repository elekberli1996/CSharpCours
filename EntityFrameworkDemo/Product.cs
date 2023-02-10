using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class Product
    {  
        
         //ilk once entity framework kutuphanesini yukleyirik
         // veri tabaninda tabloya karsilik gelen bir klasin olmasidir isimlendirmeye uyulmalidir
         //tasarim deseni

        public int Id { get; set; }
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int StockAmount { get; set; }
    }
}
