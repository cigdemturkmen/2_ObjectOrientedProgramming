using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k7_Enum
{
    class Kullanıcı
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        //public string Cinsiyet { get; set; }
        public Cinsiyet Cinsiyet { get; set; } //buradaki ilk Cinsiyet kelimesi, veri tipini gösteriyor: Cinsiyet(bu bir enum)
    }
}
