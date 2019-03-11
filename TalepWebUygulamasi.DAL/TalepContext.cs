using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalepWebUygulamasi.DAL
{
    class TalepContext : DbContext
    {
        public TalepContext() : base("") { }

        public DbSet<Talep> { get; set; }
    }
}
