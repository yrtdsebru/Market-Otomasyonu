using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity
{
    class Satici
    {
        [Key]
        public int sID { get; set; }
        public string sAdi { get; set; }
        public string sSoyadi { get; set; }
        public string sTel { get; set; }
        public decimal sBorc { get; set; }

        public ICollection<Alimlar> Alimlars { get; set; }
        
        public ICollection<YetkiliGiris> YetkiliGiris { get; set; }
    }
}
