using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    class Karga : Kus, IUcabilir
    {
        public int Yas { get; set; }
       
        double IUcabilir.UcabilecegiMaxYukseklik { get; set; }
        UzunlukBirimi IUcabilir.UcabilecegiMaxYukseklikBirimi { get; set; }

        public void Uc()
        {
            //ucma özelliği
        }
    }
}
