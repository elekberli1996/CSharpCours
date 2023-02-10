using Northwind.DataAccess.Concrete.EntityFramework;
using Nortwind.DataAccess.Abstract;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.DataAccess.Concrete.EntityFramework
{
    public class EfCatagoryDal:EfEntityRepositoryBase<Catagory,NortwindContext>,ICatagoryDal
    {

    }
}
