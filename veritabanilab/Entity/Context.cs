using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabanilab.Entity
{
    class Context : DbContext
    {
        public DbSet<tOgrenci> tOgrenci { get; set; }
        public DbSet<tFakulte> tFakulte { get; set; }
        public DbSet<tBolum> tBolum { get; set; }
        public DbSet<OgrenciDers> ogrenciDers { get; set; }
        public DbSet<tDers> tDers { get; set; }
        public DbSet<Ogretmen> tOgretmens { get; set;}
        public DbSet<tOgretmen> tOgretmen { get; set; }
    }
}