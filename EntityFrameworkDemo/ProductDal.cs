using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            
            using (ETradeContext context = new ETradeContext())
            {
              return  context.Products.ToList();
            }
        }

        public List<Product> SearchData(string key)
        {

            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();//ling
                //baza uzerinde axtaris edir boyuk datalarda performansli
            }
        }
        public List<Product> SerachByPrice(decimal key)
        {

            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice>=key).ToList();
                //baza uzerinde axtaris edir boyuk datalarda performansli
                //gelen qiymete esit ve buyuk olanlari cikarir
            }
        }
        public List<Product> SerachByPriceBetween(decimal min,decimal max)
        {

            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice<=max).ToList();
                //baza uzerinde axtaris edir boyuk datalarda performansli
                // gelen 2 qiymet araliginda arama yapar
            }
        }


        public Product GetAllId(int id)
        {

            using (ETradeContext context = new ETradeContext())
            {
                var resuult=context.Products.FirstOrDefault(p=>p.Id==id);
                //firstordefault 1 deyer aradigimizzamanmullanirik
               /// var resuult = context.Products.SingleOrDefault(p => p.Id == id);
               /// singleordefault kardesidir fakat 1 den fazla deyer taparsa hata firlastir
                return resuult; 
            }
        }

        public void Add(Product product) {
            using (ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
                //bazaya yeni veri ekler
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;//update ucun
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted; //delete ucun
                context.SaveChanges();
            }
        }
    }
}
