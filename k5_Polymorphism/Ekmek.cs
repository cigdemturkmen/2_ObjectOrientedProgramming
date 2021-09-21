using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k5_Polymorphism
{
    class Ekmek : Urun
    {
        public string EkmekTuru { get; set; }
        
        public override double KdvliFiyatGetir()
        {
            double kdvOrani = 0;
            if (EkmekTuru == "beyaz ekmek")
            {
                kdvOrani = 1.01;
            }
            else if (EkmekTuru == "karışık tahıllı")
            {
                kdvOrani = 1.05;
            }
            else if (EkmekTuru == "ekşi mayalı")
            {
                kdvOrani = 1.10;
            }
            return BirimFiyat * kdvOrani;
        }
    }
}
