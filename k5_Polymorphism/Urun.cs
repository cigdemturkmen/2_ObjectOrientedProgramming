using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k5_Polymorphism
{
    class Urun
    {
        //prop tab tab : kapalı şekilde property oluşturmak için kısa yol
        //propfull tab tab : field ve property'nin açık şekilde oluşturması için kısa yol
        //ctor tab tab : constructor'ı hızlı bir şekilde oluşturmak için kısa yol

        public double BirimFiyat { get; set; }
        public int StokMiktari { get; set; }

        public virtual double KdvliFiyatGetir()
        {
            //tüm ürünlerde %18'lik bir KDV artışı ile ürünün satış fiyatını dönen bir metot yazdık.
            return BirimFiyat * 1.18;
        }
    }
    
}
