using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k1_Class // project name
{
    public partial class Form1 : Form
    {
        /*
         OBJECT ORIENTED PROGRAMMING
        C#, java, C++, Python gibi diller nesne tabanlı dillerdir. object(nesne)

        nesne oluşturmak için > projeye sağ tıkla > Add > class > Class... Class'a isim veriyoruz.(PascalCase) 
        Bu işlem projenin altında yeni bir form oluşturmakla aynı şey aslında. Oluşturduğumuz her bir form aslında birer class'tı. (Form class'ını inherit eden class'lardı). Bizse herhangi bir class'ı inherit etmeyen bağımsız class oluşturduk örn: Ogrenci.cs, Kitap.cs

        Sonra oluşturduğumuz bu Class'ların içinde field'lar oluşturduk.(Ogrenci.cs Class'ında public field'lar) İlk örneğimizde public field kullandık(ki bu OOP'in encapsulation kuralına aykırı bir durumdu) ve public olduğu için bu fieldları başka bir Class olan Form1.cs Formunda çağırabildik.

         */
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciOlustur_Click(object sender, EventArgs e) /*burada value'lar direkt olarak field'a atandığı için yorum satırına alındı. olması gereken property'lere atanmasıydı.(private field, public property)*/
        {
            //    // Ogrenci sınıfından bir kopya olusturarak bir öğrencinin detaylı bilgisini girelim. creating an instance from Ogrenci Class.

            //    //Class'tan bir kopya üretilmesi işlemine instance almak denir. //Ogrenci sınıfından olusturulan bir nesne: ogr instance'ı.
            //    Ogrenci ogr = new Ogrenci(); //benzer işler: Random rnd = new Random();
            //    ogr._ad = "Bahar";
            //    ogr._soyad = "Taşbaş";
            //    ogr._bolum = "Elektrik Elektronik";
            //    ogr._numara = "100";

            //    Ogrenci ogr1 = new Ogrenci(); //sınıflardan oluşturulan değişkenlere(instance'lara) nesne denir.

            //    ogr1._ad = "Çiğdem";
            //    ogr1._soyad = "Türkmen";
            //    ogr1._kanGrubu = "0 RH +";
            //    ogr1._adres = "Ankara";


            //    // Ogrenci ogr2 = new Ogrenci(); fieldlar doldurulmadığı zaman null'dır.(string defaultu null olduğu için.)

            //    lblAd.Text = ogr._ad;
            //    lblSoyad.Text = ogr._soyad;
            //    lblNumarasi.Text = ogr._numara;
            //    lblAdres.Text = ogr._adres;
            //    lblKanGrubu.Text = ogr._kanGrubu;
        }

        private void btnArabaEkle_Click(object sender, EventArgs e)
        {
            // Araba sınıfı oluşturun
            // Araba sınıfı içinde arabaya ait bilgilerin tutlabilmesi için fieldlar tanımlayın
            // Araba ekle adında bir buton oluştur. basıldığında 2 farklı araba bilgisi girin

            Araba prschCarrera1 = new Araba(); //var prschCarrera1 = new Araba();

            prschCarrera1._marka = "Porsche";
            prschCarrera1._modelAdi = "Carrera";
            prschCarrera1._elektrikliMi = true;
            prschCarrera1._renk = "White";
            prschCarrera1._modelYili = 2021;

            Araba prsch9111 = new Araba();

            prsch9111._marka = "Porsche";
            prsch9111._modelAdi = "911";
            prsch9111._modelYili = 2000;
            prsch9111._elektrikliMi = false;
            prsch9111._renk = "Red";

            txtMarka.Text = prschCarrera1._marka;
            txtModelAdi.Text = prschCarrera1._modelAdi;
            txtModelYili.Text = prschCarrera1._modelYili.ToString();

            txtMarka1.Text = prsch9111._marka;
            txtModelAdi1.Text = prsch9111._modelAdi;
            txtModelYili1.Text = prsch9111._modelYili.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
