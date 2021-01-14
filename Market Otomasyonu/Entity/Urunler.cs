using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity
{
    public class Urunler
    {
        [Key]
        public int UrunKodu { get; set; }
        public Nullable<int> BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<decimal> AlisFiyati { get; set; }
        public Nullable<decimal> SatisFiyati { get; set; }
        public Nullable<int> tID { get; set; }

   
    }
}

