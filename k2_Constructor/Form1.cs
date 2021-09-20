using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2_Constructor
{
    public partial class Form1 : Form
    {
        /*
         Constructor : Yapıcı Metod(sınıfa özel bir metottur.)Sınıfın içindeki ilk metot. Sınıfı oluşturmakla görevlidir. Birden fazla overload'u yazılabilir. Eğer constructor özellikle tanımlanmazsa arkada çalışan bir constructor bulunur.

        Sınıf ile aynı isimde olmak zorundadır.
         */
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random(); //Sınıfın instance'ı oluşturulduğunda constructor metot bu şekilde çağırılır.

            // 1. tanımlama yöntemi
            Student ogrenci = new Student();
            ogrenci.Name = "ali mert";
            ogrenci.Name = "çelik";
            ogrenci.TCKN = "12345678911";

            // 2. tanımlama yöntemi
            Student ogrenci2 = new Student("bahar", "taşbaş", "11111111111");
        }
    }
}
