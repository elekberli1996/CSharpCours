using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess.Concrete
{
    class NortwindContext :DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}
