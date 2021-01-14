using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity
{
    class YetkiliGiris
    {
        [Key]
        public string NickName { get; set; }
        public string Sifre { get; set; }
        public string Yetkisi { get; set; }
        public Nullable<int> tID { get; set; }
        public Nullable<int> sID { get; set; }

        public Satici Saticis { get; set; }
        public Tedarikci Tedarikcis { get; set; }

    }
}
