
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_Class // Proje ismi
{
    class Ogrenci // Sınıflarda PascalCase notasyonu ile isimlendirme yapılır.
    {
        // Sınıfın içinde veri tutmak için oluşturulan değişkenlere field ismi verilir.
        // Field'lar isimlendirilirken değişken isimlendirme kuralları geçerlidir. Tek fark değişken ismi önünde _(underscore) bulunur.
        // _ olması program açısından bir fark yaratmaz, yine değişken olarak görecektir.
        // Sınıflar birer şablondur. Bu şablonlardan instance alınır.
        // Sınıf içinde tanımlanan elemanların erişim belirleyicisi özellikle belirtilmemişse default olarak private algılanır.
        // Aşağıdaki stringler birer field'dır. (public keywordü ile yazıldıkları için daha sonra yorum satırına alındı)

        //public string _ad;

        //public string _soyad;

        //public string _numara;

        //public string _adres;

        //public string _kanGrubu;

        //public string _bolum;

        //Yukarıda yorum satırı olan alanda field'ları public oluşturmuştuk. Şimdi ise field'ları private yapıp public property'ler kullanacağz.

        private string _ad; //Fied asıl veriyi tutan değişkendir; propertyler veri tutmaz!
        public string Ad
        {
            get
            {
                // Dışarıdan field'ın değeri istendiği zaman buradan gönderim işlemi yapılır.
                return _ad;
            }
            set
            {
                // Dışarıdan alınan verinin kontrol edilerek field'a atanması işlemi burada yapılır, alınan veri "value" olarak gösterilir.
                _ad = value;
            }
        }
        private string _soyad;
        public string Soyad
        {
            get
            {
                return _soyad;
            }
            set
            {

                _soyad = value;
            }
        }

        private string _numara;
        public string Numara
        {
            get { return _numara; }
            set { _numara = value; }
        }

        private string _adres;
        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        private string _kanGrubu;
        public string KanGrubu
        {
            get { return _kanGrubu; }
            set { _kanGrubu = value; }
        }

        private string _bolum;
        public string Bolum
        {
            get { return _bolum; }
            set { _bolum = value; }
        }

        private int _yas;
        //public int Yas
        //{
        //    get
        //    {
        //        return _yas;
        //    }
        //    set
        //    {
        //        if (value<15 || value > 18)
        //        {
        //            throw new Exception("18-15 değeri arasında bir değer atamalısınız");
        //        }
        //        _yas = value;
        //    }
        //}
        public int Yas //
        {
            get 
            {
                var simdikiZaman = DateTime.Now;
                var fark = simdikiZaman - _dogumTarihi;
                _yas = fark.Days /365 ;
                return _yas;
            }
            //set
            //{
            //    _yas = Convert.ToInt32(DateTime.Now - _dogumTarihi);
            //}
        }
        private DateTime _dogumTarihi;
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }/*Yas property'si dışarıdan alınmak zorunda değil. Yani Yas property'sinin set özelliği olmak zorunda değil. Bunun yerine Yas özelliğinin içinde return edeceği değeri hesaplattırabiliriz.(DogumTarihinin set'inden gelen veri ile bunu hesaplattırabiliriz). Ya get'in içinde ya da set'in içinde hesaplatabiliriz. set'tekini yorum satırına aldım.*/
        }

        // OOP'in encapsulation kuralı doğrusunda field'lar sınıf içinde private olarak tanımlanmalıdır.
        // Property ile field'lara kontrollü bir şekilde değerleri aktarabiliriz(set) veya field'ın taşıdığı değeri kullanıcıya gönderebiliriz(get).
        // Property'de erişim belirleyicisi public olmalıdır!
        // Property, field ile aynı veri tipinde tanımlanır(aynı tipte tanımlanırsa iyi olur?)
        // Property isimlendirme kuralında PascalCase notasyonu kullanılır.
    }

    class Araba //Bu class encapsulation kuralına uygun yazılmamıştır.(because fields are public; not encapsulated)
    {
        public string _marka;
        public string _modelAdi;
        public string _renk;
        public int _modelYili;
        public bool _elektrikliMi;
    }
}
