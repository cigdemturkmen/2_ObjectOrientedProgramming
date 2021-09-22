using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    class Marti : Kus, IYuzebilir, IUcabilir
    {
        public double YuzmeDerinligi { get; set; }

        #region Interface'den geldi. (Iyuzebilir ve IUcabilir)

        public double MaxInebilecegiDerinlik { get; set ; }
        public UzunlukBirimi Birimi { get; set; }
        
        double IUcabilir.UcabilecegiMaxYukseklik { get; set; }
        UzunlukBirimi IUcabilir.UcabilecegiMaxYukseklikBirimi { get; set; }

        public void Swim()
        {
            //Martının yüzmesi için gerekli kodlar
        }

        public void Uc()
        {
            //Martının uçması için gerekli kodlar
        }

        #endregion

    }
}
