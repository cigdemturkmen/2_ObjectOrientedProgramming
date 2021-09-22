using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k6_Abstraction
{
    public partial class Form1 : Form
    {
        /*
        Soyutlama(abstraction): Base sınıflar genellikle sadece miras vermek için oluşturulurlar yani bu sınıflardan instance almak doğru bir yöntem değildir. Bu yüzden base sınıftan instance alınmasını engelleyecek şekilde soyutlayabiliriz. Bu soyutlamayı abstract ile yaparız.
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Urun u1 = new Urun(); //urun diye bir şey aslında yok. Ondan instance almak saçma.
            //base sınıftan engellenmediği için instance oluşturabildik. base'i abstract'a çevirince aşağıdaki kod hata verdi. base'den instance alınmasının böylece önüne geçildi.

            //u1.Fiyat = 11; //hata verdi çünkü u1 abstract bir sınıftan alınan bir instance olduğu için.

            Telefon t1 = new Telefon();
            t1.Fiyat = 1200;
            var telefonSatisFiyati = t1.KdvDahilFiyatHesapla(); //override ile ezilmiş metotları çağırmak için başına instance'ını yazıyoruz(t1.)

            Bilgisayar b1 = new Bilgisayar();
            b1.Fiyat = 10000;
            var bilgisayarSatisFiyati = b1.KdvDahilFiyatHesapla();
        }
    }
}
