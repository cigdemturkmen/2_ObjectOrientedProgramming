using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k8_Interface
{
    public partial class Form1 : Form
    {
        /*
         * yetenek kazandırmak için
        Interface: Katıltımda bir sınıf sadece bir base sınıftan inheritance alabilir(phythonda böyle değil). Bu sınıfa ek özellik ya da yetenek kazandırılmak isteniyorsa bu durumda interface yapısı ile sorunu çözebiliyoruz. 
        Interface'ler implemente edilerek kullanılır. : IInterfaceName
        Istenilen sayıda interface implemente edilebilir.
        Başında I olur. bu bir kural değil standart
        Isımlendirirken -able ekleri getirilir.
        Interface içindeki elemanlara erişim belirleyici tanımlanmaz!!! Çünkü default olarak hepsi public'tir.
        Interface içinde tanımlanan metot veya property'lerin gövdeleri tanımlanmaz!
        Implemente alınan metotlarda override keyword'ünü kullanmamıza gerek yok. implementi alan sınıf o metotun içinde kendi kodlarını yazar, her biri bibirinden farklı olabilir. bu cümleyi yeniden yaz


        Kus: base
        Karga, Martı, Penguen, Tavuk sınıfı
        
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Penguen p1 = new Penguen();
            p1.Swim();
            p1.MaxInebilecegiDerinlik = 10;
            p1.Birimi = UzunlukBirimi.kilometre;
            p1.GagaBoyu = 1.2;
            p1.GagaBoyuBirimi = UzunlukBirimi.santimetre;
            MessageBox.Show($"Penguenin gaga boyu {p1.GagaBoyu} {p1.GagaBoyuBirimi}");

            var m1 = new Marti();
            m1.MaxInebilecegiDerinlik = 2;
            m1.Birimi = UzunlukBirimi.metre;

            //IUcabilir adında bir interfce oluşturup bu yeteneğe sahip sınıflara implemente ediniz.
            
        }
    }
}
