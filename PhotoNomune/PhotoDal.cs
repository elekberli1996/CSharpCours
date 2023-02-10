using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoNomune
{
    public class PhotoDal
    {
        public List<Photo> GetAll()
        {

            using (ETradeContext context = new ETradeContext())
            {
                return context.Photos.Where(p=>p.CityId==1).ToList();
            }
        }
    }
}
