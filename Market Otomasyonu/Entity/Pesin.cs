using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity
{
    class Pesin
    {
        [Key]
        public int pNo { get; set; }
        public Nullable<int> SatisNo { get; set; }
        public Nullable<int> BarkodNo { get; set; }
        public int mID { get; set; }
        public string mAdi { get; set; }
        public string mSoyadi { get; set; }
        public Nullable<System.DateTime> SatinAlmaTarihi { get; set; }

        public Satislar Satislars { get; set; }
        public Musteri Musteris { get; set; }
    }
}
