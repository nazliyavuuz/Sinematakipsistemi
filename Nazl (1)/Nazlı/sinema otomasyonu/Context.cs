using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace sinema_otomasyonu
{
    class Context:DbContext
    {
        public Context():base("baglan")
        {

        }
        public DbSet<bilet> satilankoltuklar { get; set; }
    }
}
