using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Nortwind.Business.Abstract;
using Nortwind.DataAccess.Abstract;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.Concrete
{
    public class ProductManager:IProductService
    {

        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;

        }

       // EfProductDal productDal = new EfProductDal();
        public List<Product> GetProducts()
        {

            //Business cok is katmani
         
            return _productDal.GetAll();

            //yanliz veri erisim katmani kullanilir
            // D dependenci inversion bir katman diyer katmani newleye bilmez bagilmi olursun
            // Open close prinsipi bi ekleme yapiliginda koldlarda deyisiklik  yapmamalisin
            //Code Smell
            // eyer bir class ciplak duruyorsa Code Smel
        }

    }
}
