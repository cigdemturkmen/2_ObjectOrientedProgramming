using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    class Penguen : Kus, IYuzebilir
    {
        public int YuruyusHizi { get; set; }


        #region Bu kısım interface'den geldi (Iyuzebilir)

        public double MaxInebilecegiDerinlik { get; set; }
        public UzunlukBirimi Birimi { get ; set; }

        public void Swim()
        {
            //yüzme stili tanımlanır
        }

        #endregion

    }
}
