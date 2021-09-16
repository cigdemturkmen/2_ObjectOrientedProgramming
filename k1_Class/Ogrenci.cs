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

        //public string _ad;

        //public string _soyad;

        //public string _numara;

        //public string _adres;

        //public string _kanGrubu;

        //public string _bolum;

        private string _ad; //Fied asıl veriyi tutan değişken
        public string Ad
        {
            get
            {
                //dışarıdan fieldın değeri istendiği zaman buradan gönderim işlemi yapılır
                return _ad;
            }
            set
            {
                //dışarıdan alınan verinin kontrol edilerek fielda atanması işlemi burada yapılır, value
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

        public int Yas
        {
            get 
            {
                var simdikiZaman = DateTime.Now;
                var fark = simdikiZaman - _dogumTarihi;
                _yas = fark.Days /365 ;
                return _yas;
            }
        }
        private DateTime _dogumTarihi;
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }//dışarıdan alınmak zorunda değil
        }

        //OOP'İn encapsulation kuralı doğrusunda field'lar sınıf içinde private olarak tanımlanmalıdır.
        //property ile field'lara değerleri kontrollü bir şekilde aktarabiliriz veya field'ın taşıdığı değeri kullanıcıya gönderebiliriz.
        //property'de erişim belirleyicisi public olmalıdır!
        //field ile aynı veri tipinde tanımlanır(aynı tipte tanımlanırsa iyi olur)
        //property isimlendirme kuralında PascalCase notasyonu kullanılır
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
