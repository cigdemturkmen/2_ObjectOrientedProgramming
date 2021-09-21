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
            //base sınıftan engellenmediği için instance oluşturabildik. base'i abstract'a çevirince aşağıdaki kod hata verdi. base'den instance alınmasının böylece önüne geçildi.
            //Urun u1 = new Urun(); //urun diye bir şey aslında yok. 
            //u1.Fiyat = 11;

            Telefon t1 = new Telefon();
            t1.Fiyat = 
        }
    }
}
