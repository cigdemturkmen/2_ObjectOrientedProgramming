using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_AccessModifiers
{
    class Televizyon : ElektronikUrun
    {
        public Double GerilimiDusur()
        {
            /*base sınıfta protected olarak tanımlanmış olan Gerilimdegeri property'sini burada kullanabiliyoruz. Televizyondan oluşturulan bir instancete'da görünmez eğer başka bir sınıf içinde oluşturulduysa bu instance.*/
            return GerilimDegeri / 10;
        }

    }
}
