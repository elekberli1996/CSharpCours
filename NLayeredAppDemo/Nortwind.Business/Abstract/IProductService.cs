﻿using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
