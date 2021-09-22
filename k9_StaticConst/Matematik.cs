using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k9_StaticConst
{
    public static class Matematik
    {
        public const double EulerSabiti = 0.5777721; //ya static yazarsın ya da const yazarsın. static yazarsan değeri sonradan değişir. Bu değer programın her noktasında bu sayı ile çalışacak. sonradan değeri değiştirilemez.

        public const double PisagorSabiti = 1.4142135;

        public static double karelerFarkiniAl(double sayi1, double sayi2)
        {
            var sayi1Karesi = Math.Pow(sayi1, 2);
            var sayi2Karesi = Math.Pow(sayi2, 2);
            var kareFarki = sayi1Karesi - sayi2Karesi;
            return kareFarki;

        }
    }
}
