using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity
{
    class Tedarikci
    {
        [Key]
        public int tID { get; set; }
        public string tAdi { get; set; }
        public string tSoyadi { get; set; }
        public string tTel { get; set; }
        public decimal tBorc { get; set; }

        public ICollection<Alimlar> Alimlars { get; set; }
        public ICollection<YetkiliGiris> YetkiliGiris { get; set; }
        public ICollection<Urunler> Urunlers { get; set; }
    }
}
