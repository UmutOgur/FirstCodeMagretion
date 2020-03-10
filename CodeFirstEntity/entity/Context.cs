using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity.entity
{
    class Context : DbContext
    {
        public DbSet<Ürünler> Ürünlers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }

        public DbSet<Müsteri> Müsteris { get; set; }

        public DbSet<Personel> Personels { get; set; } 
    }
}
