using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k1_Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        //Bu form'da set içinde if koşulu yazarak kontrollü bir şekilde verinin alınması konusu işlendi.


        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            /*Ogrenci sınıfı oluşturalım > Ogrenci.cs oluşturuldu. OgrenciEkle butonuyla adı Bahar olan bir öğrenci eklemeyi deneyeceğiz fakat yalnızca eklenecek öğrencinin yaşının girilmesi gerekiyor. Bunun için Yas property'sinin set blogu kullanılacak, kosullu bir kayıt istediğimiz için set bloguna if ile koşul yazacağız. Kaydedilecek öğrencinin yaşı 15 - 18 aralığında olmalı. Ogrenci.cs'de property'i yazarken set'in içine ifle bu koşulu yazdık.*/

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Bahar"; // set bloğu çalışır.
            //ogrenci1.Yas = 5; //dersek hata verir çünkü set bloğunda buna engel bir if bloğu yazıldı.
            
            //Ya da ogrenci1.Yas'a textboxtan da aralık dışında bir şey atamaya çalışsak hata verir:
            var yas = Convert.ToInt32(txtYas.Text);
            try
            {
                //ogrenci1.Yas = 11; //sonradan yaşı dogum tarihinden hesapladığımız için burayı yorum satırına aldık.
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //ogrenci1.Yas = 11;

            MessageBox.Show(ogrenci1.Ad); //get bloğu çalışır.
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
