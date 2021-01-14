using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity
{
    class Satislar
    {
        [Key]
        public int SatisNo { get; set; }
        public Nullable<int> mID { get; set; }
        public Nullable<int> UrunKodu { get; set; }
        public Nullable<int> BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<bool> OdemeSekli { get; set; }

        public ICollection<Cari> Caris { get; set; }
        public ICollection<Irsaliye> Irsaliyes { get; set; }
        public ICollection<Pesin> Pesins { get; set; }
        public Stoklar Stoklars { get; set; }
        public Urunler Urunlers { get; set; }
        public Musteri Musteris { get; set; }
    }
}
