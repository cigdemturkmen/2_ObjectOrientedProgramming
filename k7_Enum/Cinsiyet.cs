using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k7_Enum
{
    //eğer belirtilmezse ilk enum'ın sayısal değeri default int değerini alır, yani 0. sonrakiler 1, 2, 3 diye devam eder. Veri tabanına bu sayısal değerlerle kaydolur.

    enum Cinsiyet //Class Cinsiyet'i silip "enum Cinsiyet" yazdık
    {
        Kadin = 0,
        Erkek = 1
    }
}
