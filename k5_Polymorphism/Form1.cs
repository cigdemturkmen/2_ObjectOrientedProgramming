using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k5_Polymorphism
{
    public partial class Form1 : Form
    {
        /* 
        Çok biçimlilik(polymorphism):  base sınıfta yazılan bir metot ya da property'nin derived sınıflarda base'de tanımlandığından farklı bir şekilde kullanılmasına denir.
        virtual anahtar kelimesi ile tanımlanan eleman, miras alınan sınıf içinde override anahtar kelimesi ile ezilebilir ve farklı bir biçimde kullanılabilir.
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba a1 = new Araba();
            a1.MotorHacmi = 1000;
            a1.BirimFiyat = 10000;
            var arabaninFiyati = a1.KdvliFiyatGetir();

            var araba1 = new Araba();
            araba1.MotorHacmi = 2500;
            araba1.BirimFiyat = 50000;
            var araba1SatisFiyati = araba1.KdvliFiyatGetir();

            Ekmek ekmek = new Ekmek();
            ekmek.BirimFiyat = 1.98;
            ekmek.StokMiktari = 1000;
            var ekmekSatisFiyati = ekmek.KdvliFiyatGetir();

            Ekmek ekmek2 = new Ekmek();
            ekmek.BirimFiyat = 5;
            ekmek.EkmekTuru = "karışık tahıllı";
            var karisikTahilliSatisFiyati = ekmek2.KdvliFiyatGetir();

        }
    }
}
