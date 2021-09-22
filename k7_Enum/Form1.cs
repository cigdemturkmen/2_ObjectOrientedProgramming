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
            //Cinsiyet.Erkek (enum.içindekiDeğer)

            var yazi = Cinsiyet.Kadin.ToString(); //Kadin : string kısmını istiyorum
            var sayisalKismi = (int)Cinsiyet.Erkek; //1 : sayısal kısmı istiyorum
            //var s = Convert.ToInt32(Cinsiyet.Erkek); //Bu kullanım kullanılmıyor!
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanıcı k1 = new Kullanıcı();

            var ad = txtAd.Text;

            var soyad = txtSoyad.Text;

            //textbox ile seçim:
            //var cinsiyet = txtCinsiyet.Text; //jfhsaasdas textboxla aldırırsak böyle bir sorunla karşılaşabiliriz.

            //combobox ile seçim:
            var cinsiyet = cmbCinsiyet.SelectedItem.ToString(); /*burada da programcı yanlışlıkla kadın-erkek dışında bir string girebilir. çünkü Kullanıcı.cs'de Cinsiyet property'si string tipinde! Böyle bir şeyin önüne geçmek için veri tipini Cinsiyet yapabiliriz. Cinsiyet enum'ını tanımladıktan sonra tabi ki!*/

            //radiobox ile seçim:
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
            //k1.Cinsiyet = 0;


        }
    }
}
