using Nortwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Entities.Concrete
{
    public class Catagory:IEntity
    {
        public int CatagoryID { get; set; }
        public string CatagoryName { get; set; }
    }
}
