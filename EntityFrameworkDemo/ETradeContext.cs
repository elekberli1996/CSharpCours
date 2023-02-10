using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class ETradeContext: DbContext
    {
        // veri tabani isminde bi kontekst yaradiriq
        // entity frmame Work olmasi ucun entity frame workun DbContext kutuphanesinden inherit edilmesi gerek
        // en temel yapilandirma sudur
        //temel anlamda conteksimizi olusturduk

        //appconfigde connection string ekleyirik
        public DbSet<Product> Products { get; set; }

    }
}
