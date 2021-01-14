using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity
{
    class Alimlar
    {
        [Key]
        public int aİrsaliyeNo { get; set; }
        public Nullable<int> tID { get; set; }
        public Nullable<int> sID { get; set; }
        public Nullable<int> aUrunKodu { get; set; }
        public Nullable<int> aBarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<decimal> Miktari { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public Nullable<System.DateTime> AlimTarihi { get; set; }
        public Nullable<bool> OdemeSekli { get; set; }

        public Satici Saticis { get; set; }
        public Tedarikci Tedarikcis { get; set; }
        public ICollection<Urunler> Urunlers { get; set; }     
    }
}
