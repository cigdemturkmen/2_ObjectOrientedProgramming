using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k6_Abstraction
{
    class Telefon : Urun
    {
        public string EkranBoyutu { get; set; }

        public override double KdvDahilFiyatHesapla()
        {
            return Fiyat * 1.08;
        }
    }
}
