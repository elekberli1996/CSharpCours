using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Entities.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }

        public int CategoryID { get; set; }
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public Int16 UnitsInStock { get; set; }

        public string QuantityPerUnit { get; set; }

    }
}
