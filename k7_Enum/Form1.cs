using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k7_Enum
{
    public partial class Form1 : Form
    {
        /*
        Enum: program içinde kullanmak için sabit değerler tanımlamak isterseniz enum'ları kullanabilirsiniz.(kullanıcının girmemesi gereken bir veri girmesini engeller) Amacı yazılım geliştirirken belli standartları koruyabilmek ve kolaylık sağlamak için tanımlanır.

         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //konu anlatımı
            //Cinsiyet.Erkek

            var yazi = Cinsiyet.Kadin.ToString(); //Kadin - string kısmını istiyorum
            var sayisalKismi = (int)Cinsiyet.Erkek; //1 - sayısal kısmı istiyorum
            //var s = Convert.ToInt32(Cinsiyet.Erkek); //bu kullanım kullanılmıyor
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanıcı k1 = new Kullanıcı();

            var ad = txtAd;

            var soyad = txtSoyad;

            //var cinsiyet = txtCinsiyet.Text; //jfhsaasdas

            var cinsiyet = cmbCinsiyet.SelectedItem.ToString(); //kadın/erkek

            //radiobox ile seçim
            //if (rdbKadin.Checked)
            //{
            //    k1.Cinsiyet = Cinsiyet.Kadin;
            //}
            //else if (rdbErkek.Checked)
            //{
            //    k1.Cinsiyet = Cinsiyet.Erkek;
            //}


            k1.Ad = ad;
            k1.Soyad = soyad;
            k1.Cinsiyet = Cinsiyet.Kadin;


        }
    }
}
