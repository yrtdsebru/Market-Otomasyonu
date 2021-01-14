using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity
{
    class Musteri
    {
        [Key]
        public int mID { get; set; }
        public string mAdi { get; set; }
        public string mSoyadi { get; set; }
        public string mTel { get; set; }
        public decimal mBorc { get; set; }

        public ICollection<Satislar> Satislars { get; set; }
        public ICollection<Cari> Caris { get; set; }
        public ICollection<Pesin> Pesins { get; set; }

    }
}
