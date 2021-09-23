using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k10_List
{
    public partial class ListeMetotları : Form
    {
        public ListeMetotları()
        {
            InitializeComponent();
        }

        private void btnAvarage_Click(object sender, EventArgs e)
        {
            //ortalama alan metot

            var sayilar = new List<int> { 12, 123, 41, 512, 52, 44 };
            //extention metot: sayilar için hazırlanmış özel metotlar(küp ve aşağı yönlü ok sembolü)
            var ortalama = sayilar.Average();

            MessageBox.Show(ortalama.ToString());


            //lambda expression
            //sayilar listesindeki tüm elemanlara 3 ekledikten sonra ortalamasını al 
            var ortalama2 = sayilar.Average(sayi => sayi + 3); //Func<Tsource, int> 
            //parantezin içi lambda expression... parantez açınca Func görüyorsam lambda expr. kullanabilirsin.
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            // concat: liste birleştirmek için kullanılır

            var fizikselOgrenciler = new List<string>() { "ömer", "leyla", "çiğdem", "orkun", "batuhan", "anıl" };
            var onlineOgrenciler = new List<string>() { "mustafa", "mert", "tuğçe", "eray", "utku", "batu" };

            var tumOgrencilerListesi = fizikselOgrenciler.Concat(onlineOgrenciler).ToList(); //concat sana çok genel bir şey veriyor. o yüzden ToList yaptık.

            // .ToList() : listeye çevir

            foreach (var item in tumOgrencilerListesi)
            {
                listBox1.Items.Add(item);
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            var sayilar = new List<int>() { 29, 11, 10, 9, 2, 3, 45 };

            var sayilarListesindekiElemanSayisi = sayilar.Count; //aynı sonuç döner

            var elemanSayisi = sayilar.Count(); //atnı sonuç döner

            var ondanBuyukOlanlarinSayisi = sayilar.Count(sayi => sayi > 10);

            //2 katı 50den kücük olanları sayısı

            var ikiKatiEllidenKucukOlanlarinSayisi = sayilar.Count(x => 2 * x < 50);
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            var sayilar = new List<int>() { 29, 11, 10, 9, 2, 3, 45 };

            var iceriyorMu = sayilar.Contains(30); //true ya da false döner. contains içine lambda exp yani func yazamıyoruz

            //sayilar listes içinde 100'den büyük bir değer var mı?

            var yüzdenBuyukDegerVarMi = sayilar.Exists(x => x > 100); //false 
            var ikidenBuyukDegerVarMi = sayilar.Exists(x => x > 2 && x < 100); //true
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            var ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci(){Ad= "Bahar", Soyad="Taşbaş", Yas = 27},
                new Ogrenci(){Ad="Serdar", Soyad= "Turan", Yas=32},
                new Ogrenci(){Ad="Batuhan", Soyad="Alakaş" ,Yas=26 }
            };

            //func, predicate
            var sonuc1 = ogrenciler.Exists(ogrenci => ogrenci.Ad == "bahar"); //adı bahar olan öğrenci var mı?
            var sonuc2 = ogrenciler.Exists(x => x.Yas < 30); //yas degeri 30dan kucuk öğr var mı?
        }

        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            //eğer içine bir kriter yazılırsa o kriteri sağlayan ilk sonucu döndürür.
            //eğer kriteri sağlayan bir değer bulunamazsa null sonucu verir(default değeri).

            var ogrenciler = new List<Ogrenci>()
            {
            new Ogrenci() { Ad = "Bahar", Soyad = "Taşbaş", Yas = 27 },
                new Ogrenci() { Ad = "Serdar", Soyad = "Turan", Yas = 32 },
                new Ogrenci() { Ad = "leyla1", Soyad = "Taş", Yas = 32 },
                new Ogrenci() { Ad = "Batuhan", Soyad = "Alakaş", Yas = 26 },
                new Ogrenci() { Ad = "ömer", Soyad = "Eroğlu", Yas = 27 },
                new Ogrenci() { Ad = "leyla", Soyad = "Taş", Yas = 27 },
                new Ogrenci() { Ad = "Batuhan", Soyad = "Alakaş", Yas = 26 }
            };

            //yaşı 27 olan kişiyi getiriniz

            var sonuc = ogrenciler.FirstOrDefault(x => x.Yas == 27);

            //yaşı 27 olan soyadı içinde taş geçen sonucu getiriniz.

            var sonuc2 = ogrenciler.FirstOrDefault(x => x.Yas == 27 && x.Soyad.Contains("Taş"));

            var sonuc3 = ogrenciler.LastOrDefault(x => x.Yas == 27 && x.Soyad.Contains("Taş"));
            //eğer içine bir kriter yazılırsa o kriteri sağlayan sonuncu elemanı döndürür.

            
            var sonuc4 = ogrenciler.LastOrDefault(x => x.Yas == 99 && x.Soyad.Contains("Taş"));
            //MessageBox.Show(sonuc4.Ad); PATLAR

            //null check!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (sonuc4 != null)
            {
                MessageBox.Show(sonuc4.Ad);
            }
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            //where içine yazılan kriteri sağlayan birden fazla sonuç varsa tümünü verir.

            var ogrenciler = new List<Ogrenci>()
            {
            new Ogrenci() { Ad = "Bahar", Soyad = "Taşbaş", Yas = 27 },
                new Ogrenci() { Ad = "Serdar", Soyad = "Turan", Yas = 32 },
                new Ogrenci() { Ad = "leyla1", Soyad = "Taş", Yas = 32 },
                new Ogrenci() { Ad = "Batuhan", Soyad = "Alakaş", Yas = 26 },
                new Ogrenci() { Ad = "ömer", Soyad = "Eroğlu", Yas = 27 },
                new Ogrenci() { Ad = "leyla", Soyad = "Taş", Yas = 27 },
                new Ogrenci() { Ad = "Batuhan", Soyad = "Alakaş", Yas = 26 }
            };

            //yasi 27 olanları getirin

            var sonuc = ogrenciler.Where(x => x.Yas == 27).ToList();
            var sonuc1 = ogrenciler.Where(x => x.Yas == 27); // burdan enumerable türünde bişi döner. foreachte hata vermez ama listeye özgü bişi kullanılmak istenirse ToList() yapılmalı.

            //foreach (var item in sonuc1)
            //{
            //    listBox1.Items.Add(item);
            //}

            //adı 6 harfli olanları getir
            var sonuc2 = ogrenciler.Where(x => x.Ad.Length == 6).ToList();
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            var sayilar = new List<int>() { 29, 11, 10, 9, 2, 3, 45 };

            var minDeger = sayilar.Min();
            var maxDeger = sayilar.Max();

            var ogrenciler = new List<Ogrenci>()
            {
            new Ogrenci() { Ad = "Bahar", Soyad = "Taşbaş", Yas = 27 },
                new Ogrenci() { Ad = "Serdar", Soyad = "Turan", Yas = 32 },
                new Ogrenci() { Ad = "leyla1", Soyad = "Taş", Yas = 32 },
                new Ogrenci() { Ad = "Batuhan", Soyad = "Alakaş", Yas = 26 },
                new Ogrenci() { Ad = "ömer", Soyad = "Eroğlu", Yas = 27 },
                new Ogrenci() { Ad = "leyla", Soyad = "Taş", Yas = 27 },
                new Ogrenci() { Ad = "Batuhan", Soyad = "Alakaş", Yas = 26 }
            };

            var enGencOgrenciYasi = ogrenciler.Min(x => x.Yas);
            var enYasliOgrenciYasi = ogrenciler.Max(x => x.Yas);


            //en genç öğrencinin tüm bilgilerini getirmek isteseydil.

            //var enGencOgrenci = ogrenciler.FirstOrDefault(x => x.Yas == enGencOgrenciYasi);
            var enGencOgrenci = ogrenciler.FirstOrDefault(x => x.Yas == ogrenciler.Min(y => y.Yas));
        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {
            //order by    (ascending)
            //order by descending

            var sayilar = new List<int>() { 29, 11, 10, 9, 2, 3, 45 };
            var siralanmısListe = sayilar.OrderBy(x => x).ToList();

            var ogrenciler = new List<Ogrenci>()
            {
            new Ogrenci() { Ad = "Bahar", Soyad = "Taşbaş", Yas = 27 },
                new Ogrenci() { Ad = "Serdar", Soyad = "Turan", Yas = 32 },
                new Ogrenci() { Ad = "leyla1", Soyad = "Taş", Yas = 32 },
                new Ogrenci() { Ad = "Batuhan", Soyad = "Alakaş", Yas = 26 },
                new Ogrenci() { Ad = "ömer", Soyad = "Eroğlu", Yas = 27 },
                new Ogrenci() { Ad = "leyla", Soyad = "Taş", Yas = 27 },
                new Ogrenci() { Ad = "Batuhan", Soyad = "Alakaş", Yas = 26 }
            };

            var adaGoreSiralanmisListe = ogrenciler.OrderByDescending(x => x.Soyad);

        }
    }
}
