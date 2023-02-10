using Nortwind.Business.Abstract;
using Nortwind.DataAccess.Concrete.EntityFramework;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.Concrete
{
    public class CatagoryManager : ICatagoryService
    {
        private EfCatagoryDal efCatagoryDal;

        public CatagoryManager(EfCatagoryDal efCatagoryDal)
        {
            this.efCatagoryDal = efCatagoryDal;
        }

        public List<Catagory> getAll()
        {
            throw new NotImplementedException();
        }
    }
}
