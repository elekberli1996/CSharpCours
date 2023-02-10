using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nortwind.Entities.Concrete;

namespace Nortwind.Business.Abstract
{
    public interface ICatagoryService
    {
        List<Catagory> getAll();

    }
}
