using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k5_Polymorphism
{
    //SOLID
    class Araba : Urun
    {
        public string Model { get; set; }

        public int MotorHacmi { get; set; }

        public override double KdvliFiyatGetir() //override diyerek metodu ezdik.
        {
            //Motor hacmine göre farklı KDV oranları getiren metot yaz.
            //1000-2000 -> %45, 2000-2500 -> %150, 2500-2500 üzeri -> %300
            //return base.KdvliFiyatGetir(); metotun ezilmemiş hali, base'deki hali.

            double kdv = 0.0;
            if (MotorHacmi < 1000 || MotorHacmi > 8000)
            {
                throw new Exception("Motor hacmi en az 1000 CC olmalıdır.");
            }
            if (MotorHacmi >= 1000 && MotorHacmi <2000)
            {
                kdv = 1.45;
            }
            else if (MotorHacmi >=2000 && MotorHacmi < 2500)
            {
                kdv=  2.50;
            }
            else if (MotorHacmi >= 2500)
            {
                kdv = 4.00;
            }
            else
            {
                kdv = 0;
            }
            return BirimFiyat * kdv;
        }
    }
}
