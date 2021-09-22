using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    class Tavuk : Kus, IUcabilir
    {
        public int AylikYumurtaSayisi { get; set; }
        public double YumurtlamaSuresi { get; set; }
        public double UcabilecegiMaxYukseklik { get; set; }
        public UzunlukBirimi UcabilecegiMaxYukseklikBirimi { get; set; }

        public void Uc()
        {
            //Tavugun ucması için gerekli kodlar
        }
    }
}
