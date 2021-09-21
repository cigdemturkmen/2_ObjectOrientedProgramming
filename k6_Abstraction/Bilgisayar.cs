using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k6_Abstraction
{
    class Bilgisayar : Urun
    {
        public int RamBoyutu { get; set; }
        public int HarddsiskBoyutu { get; set; }

        public override double KdvHesapla()
        {
            return Fiyat * 1.12;
        }
    }
}


