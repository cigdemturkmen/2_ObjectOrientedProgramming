using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        // Generic List && ArrayList
        public Form1()
        {
            InitializeComponent();
        }

        List<int> sayilar = new List<int>(); //generic list

        private void btnList_Click(object sender, EventArgs e)
        {
            /*
            ArrayList
            */
            ArrayList iller = new ArrayList(); //içine her türlü eleman alıyor çünkü içine object türünde veri istiyor.
            iller.Add("ankara"); //boxing. (kullanmak için unboxing yapmak gerekecek)
            iller.Add(34);
            iller.Add(true);

            //T: herhangi bir veri tipi.(generic şeyler T ile gösteriliyor)
            
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);

            List<bool> sonuclar = new List<bool>() { true, false, false, true, true }; //ikinci eleman ekl. yönt.
            sonuclar.Add(true);

            //bolumler adında bir liste oluşturunuz ve içine birkaç veri giriniz.

            List<string> bolumler = new List<string> { "bilgisayar mühendisliği", "inşaat mühendisliği", "biyoloji", "kimya", "fizik" };
            bolumler[2] = "test";

            foreach (var item in bolumler)
            {
                listBox1.Items.Add(item);
                //MessageBox.Show(bolumler[0]); //denemeler...
            }

            var listeninElemanSayisi = bolumler.Count; // bu listede kaç eleman old. gösterir.

            List<Motosiklet> motosikletler = new List<Motosiklet>();

            // 1.nesne oluşturma yöntemi
            Motosiklet m1 = new Motosiklet();
            m1.MotorHami = 1.2;
            m1.TekerlekSayisi = 2;
            m1.Rengi = Color.Black;

            motosikletler.Add(m1);

            // 2. yöntem
            Motosiklet m2 = new Motosiklet()
            {
                MotorHami = 0.6,
                Rengi = Color.Red,
                TekerlekSayisi = 3
            };

            motosikletler.Add(m2);

            // 3. yöntem
            var ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci(){Ad= "Bahar", Soyad="Taşbaş", Yas = 27},
                new Ogrenci(){Ad="Serdar", Soyad= "Turan", Yas=32},
                new Ogrenci(){Ad="Batuhan", Soyad="Alakaş" ,Yas=26 }
            };

            foreach (var item in ogrenciler)
            {
                //listBox1.Items.Add(item); // ToString'i ezmeyince namespace geldi. namespace.ClassAdi
                listBox1.Items.Add(item.Ad + " " + item.Soyad); // ama bu kodla öğrencinin tamamı gelmez
                listBox1.Items.Add(item); // ToString ezildikten sonra...
            }

        }
    }
}
