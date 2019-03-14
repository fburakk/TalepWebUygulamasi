using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalepWebUygulamasi.Entities;

namespace TalepWebUygulamasi.DAL
{
    public class TalepContext : DbContext, IDisposable
    {
        public TalepContext() : base("name=TalepWebUygulamasiConnection") { }

        public DbSet<Talep> Talepler { get; set; }
        public DbSet<HUser> Kullanıcılar { get; set; }
    }
}
