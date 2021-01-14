using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity
{
    class Stoklar
    {
        [Key]
        public int StokNo { get; set; }
        public Nullable<int> BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<decimal> MevcutStok { get; set; }
        public Nullable<decimal> KritikStok { get; set; }

        public ICollection<Satislar> Satislars { get; set; }

    }
}
