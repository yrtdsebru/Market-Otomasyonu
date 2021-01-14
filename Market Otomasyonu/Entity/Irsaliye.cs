using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity
{
    class Irsaliye
    {
        [Key]
        public int IrsaliyeNo { get; set; }
        public Nullable<int> SatisNo { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<decimal> Miktari { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<System.DateTime> SatimTarihi { get; set; }
        public Nullable<decimal> Tutar { get; set; }

        public Satislar Satislars { get; set; }
    }
}
