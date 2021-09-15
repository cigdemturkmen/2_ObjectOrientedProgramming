using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_Class //hangi projede yer alıyorsa onun ismi geliyor.
{
    class Ogrenci //sınıflar PascalCase notasyonu ile isimlendirme yapılır
    {
        //sınıfın içinde veri tutmak için oluşturulan değişkenlere field ismi verilir.
        //field'lar isimlendirilirken değişken isimlendirme kuralları geçerlidir. tek fark değişken ismi önünde _ bulunur.
        //_ olması program açısından bir fark yaratmaz, değişken olarak görecektir.
        //sınıflar birer şablondur
        //sınıf içinde tanımlanan elemanların erişim belirleyicisi özellikle belirtilmemişse default olarak private algılanır.
        //aşağıdaki stringler birer field'dır.
        public string _ad;

        public string _soyad;

        public string _numara;

        public string _adres;

        public string _kanGrubu;

        public string _bolum;
    }

    class Araba
    {
        public string _marka;
        public string _modelAdi;
        public string _renk;
        public int _modelYili;
        public bool _elektrikliMi;
    }
}
