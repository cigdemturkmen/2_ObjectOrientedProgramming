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
         Constructor : Yapıcı Metottur(İçinde olduğu sınıfa özel bir metottur.)Sınıfın içindeki ilk metottur. Sınıfı oluşturmakla görevlidir. Birden fazla overload'u yazılabilir. Eğer constructor özellikle tanımlanmazsa arkada çalışan bir constructor bulunur. o da şöyledir; public ClassName(){}

        Sınıf ile aynı isimde olmak zorundadır.
        Constructor metodu bir classtan instance alırken kullanılır(çağırılır).örn: Random rnd = new Random();
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random(); //Sınıfın instance'ı oluşturulduğunda constructor metot bu şekilde çağırılır. new'den sonraki Random(); constructor'dır.

            //  instance tanımlama yöntemi 1 :
            //  parametresi olmayan constructor overload'u ile(bu instance Student() metodu ile oluşturuldu.)
            Student ogrenci = new Student();
            ogrenci.Name = "ali mert";
            ogrenci.Name = "çelik";
            ogrenci.TCKN = "12345678911";

            // instance tanımlama yöntemi 2 : Constructor metodunun parametre alan bir overload'u ile.
            Student ogrenci2 = new Student("bahar", "taşbaş", "11111111111"); //constructor'ın bu overloadu Student.cs içinde yazıldı.
        }
    }
}
