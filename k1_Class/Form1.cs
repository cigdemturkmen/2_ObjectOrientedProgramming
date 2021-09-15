using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k1_Class
{
    public partial class Form1 : Form
    {
        /*
         Object Oriented Programming
        C#, java, C++, Python

        object(nesne)

        nesne oluşturmak için > projeye sağ tıklayıp > class seçiyoruz, sınıfın adını veriyoruz.


         */
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciOlustur_Click(object sender, EventArgs e)
        {
            //ogrenci sınıfından bir kopya olusturarak bir öğrencinin detaylı bilgisini girelim.

            //sınıftan bir kopya üretilmesi işlemine instance almak denir. //Ogrenci sınıfından olusturulan bir nesne.
            Ogrenci ogr = new Ogrenci(); //Random rnd = new Random();
            ogr._ad = "Bahar";
            ogr._soyad = "Taşbaş";
            ogr._bolum = "Elektrik Elektronik";
            ogr._numara = "100";

            Ogrenci ogr1 = new Ogrenci(); //sınıflardan oluşturulan değişkenlere nesne denir.

            ogr1._ad = "Çiğdem";
            ogr1._soyad = "Türkmen";
            ogr1._kanGrubu = "0 RH +";
            ogr1._adres = "Ankara";
 
            
            //Ogrenci ogr2 = new Ogrenci(); fieldlar null'dır.(string default)

            lblAd.Text = ogr._ad;
            lblSoyad.Text = ogr._soyad;
            lblNumarasi.Text = ogr._numara;
            lblAdres.Text = ogr._adres;
            lblKanGrubu.Text = ogr._kanGrubu;
        }

        private void btnArabaEkle_Click(object sender, EventArgs e)
        {
            //araba sınıfı oluşturun
            //araba sınıfı içinde arabaya ait bilgilerin tutlabilmesi için fieldlar tanımlayınız
            // araba ekle adında bir buton oluştur. basıldığında 3 farklı araba bilgisi giriniz.

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


        }
    }
}
