using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void StockControl();
    public class Product
    {
        int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }
        //eventler bi delege kullanilmadan
        public event StockControl StockControlEvent;


        public string ProductName { get; set; }
        public int Stock {
            get { return _stock; } //stok okunuyor
            set {
                _stock = value;
                if(value<=15 && StockControlEvent != null)
                {//stok set edilyor 15den azsa ve evente abune olumussa calisir
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} stock Amount: {0}", Stock,ProductName);
        }
    }
}
