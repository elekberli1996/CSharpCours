
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class NortwindContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }

    }
}
