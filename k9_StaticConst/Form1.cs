using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k9_StaticConst
{
    public partial class Form1 : Form
    {
        /*
        static keyword: eğer bir sınıf static ile işaretlenirse bu sınıftan instance alınamaz.Ram üzerine bir kez çıkmasını sağlayan anahtar kelimedir(tek instance gibi düşün). Bu sınıf içinde tanımlanan tüm metot veya propertyler de static tanımlanmak zorundadır. Kullanılmak istendiğinde SinifAdi.PropertyAdi veya SinifAdi.MetotAdi() şeklinde kullanım yapılır.
        ***static kullanırken 3 kez düşünün(SEPET ÖRNEĞİ!!!)
        **garbage collector: static nesnelere dokunmaz. applikasyon kapanana kadar ram'de kalır. Projeyi kapatınca ram'den silinir.
        *kullanım amacı örn: online kullanıcı göster vs . math sınıfı statictir.

        const keyword: Sabit bir değer tanımlamak için kullanılır ve değeri sonradan değiştirilemez.
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Matematik sınıfı static olmasaydı instance alıp kullanmak zorundaydık
            //Matematik m1 = new Matematik();
            //var sonuc = m1.KarelerFarkiniAl();

            //Matematik sınıfı static olduğu için direkt instance anlamadan kullanabiliyoruz
            var sonuc = Matematik.karelerFarkiniAl(2, 3);
            var eulerSabiti = Matematik.EulerSabiti;

            //helper
        }
    }
}
