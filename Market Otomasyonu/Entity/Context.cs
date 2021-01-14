using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Market_Otomasyonu.Entity
{
    class Context : DbContext
    {
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Alimlar> Alimlars { get; set; }
        public DbSet<Cari> Caris { get; set; }
        public DbSet<Irsaliye> Irsaliyes  { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Pesin> Pesins { get; set; }
        public DbSet<Satici> Saticis { get; set; }
        public DbSet<Satislar> Satislars { get; set; }
        public DbSet<Stoklar> Stoklars { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<YetkiliGiris> YetkiliGirises { get; set; }

    }
}
