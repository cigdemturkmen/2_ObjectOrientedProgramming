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
    public partial class KitapKayitSayfasi : Form
    {
        public KitapKayitSayfasi()
        {
            InitializeComponent();
        }
        /* YENİ KANVRAMLAR
        
        -DateTimePicker nesnesi ve onun Value özelliği.
        -Classlar da birer veri tipidir.
        -ComboBox SelectedItem, ComboBox SelectedIndex
        -this.Controls ile formdaki tüm elemanları foreach ile gezebiliriz.
        -foreachdeki item object türünde bir nesnedir. onu mesela şu şekilde cast ettik (TextBox)item
        -ComboBox'ın SelectedIndexChanged event'i.
        -ListBox'ın SelectedIndexChnaged event'i
        -is keywordü > örnek: if(item is Textbox)
        -Formdaki tüm nesnelerin TabIndex özelliği. tab tab yaparak giderken hangi sırayı izleyeceği...
        -ComboBox'ın AutoCompleteMode ve AutoCompleteSource özelliği. sırasıyla Suggest ve ListItems seçenekleri güzel...
        -Combobox'ın DropDownStyle özelliğinde DropDownList seçilirse, kullanıcı kendisi yeni bir şey yazamaz.

        */

        // Kitap adı, yazarın adı soyadı, fiyatı, türü, yayınevi, basım tarihi, sayfa sayısı bilgilerini alarak kitaplar[] içinde tutan bir uygulama yapalım.

        private void KitapKayitSayfasi_Load(object sender, EventArgs e)
        {
            // Bu işlemi türler dizisi oluşturup AddRange metodunu kullanarak da ekleyebilirsin.
            cmbTuru.Items.Add("Çizgi Roman");
            cmbTuru.Items.Add("Hikaye");
            cmbTuru.Items.Add("Polisiye");
            cmbTuru.Items.Add("Biyografi");
            cmbTuru.Items.Add("Roman");
            cmbTuru.Items.Add("Kişisel Gelişim");
            cmbTuru.Items.Add("Psikoloji");
            cmbTuru.Items.Add("Tarih");
        }

        Kitap[] kitaplar = new Kitap[0];

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(); //kitap1, kitap2 gibi farklı instance'lara gerek yok çünkü butona her basıldığında tek bir kitap kaydolacak onun için bu kullanım yeterli.


            kitap.KitapAdi = txtKitapAdi.Text; // atadığın değerleri sağa yaz hep! diğer türlü dtp'de hata verdi.
            kitap.Yayinevi = txtYayinevi.Text;
            kitap.Fiyat = Convert.ToDouble(txtFiyat.Text);
            kitap.Turu = cmbTuru.SelectedItem.ToString();
            kitap.Yayinevi = txtYayinevi.Text;
            kitap.BasimTarihi = dtpBasimTarihi.Value;
            kitap.SayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text);

            Array.Resize(ref kitaplar, kitaplar.Length + 1);
            kitaplar[kitaplar.Length - 1] = kitap;

            MessageBox.Show("Kitap başarıyla kaydedilmiştir.");

            FormuTemizle();
        } 

        private void FormuTemizle()
        {
            /*kaydetme işlemi tamamlandıktan sonra ya da temizleme butonuna basıldığında textbox, combobox, datepicker'ı temizleyecek bir metot*/

            //txtKitapAdi.Clear();
            //txtYazarAdi.Clear();
            //txtYayinevi.Clear();
            //txtFiyat.Clear();
            //txtSayfaSayisi.Clear();

            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    var txt = (TextBox)item; //burada item'ın türü object olduğu için onu TextBox'a cast ettik.
                    txt.Clear();
                }
            }

            cmbTuru.SelectedIndex = -1;

            dtpBasimTarihi.Value = DateTime.Now;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        
        private void btnKitaplarıListele_Click(object sender, EventArgs e)
        {
            //kitap[] içindekileri listbox'a ekleyelim.
            foreach (var item in kitaplar)
            {
                lstKitaplar.Items.Add(item);//????BU KOD NASIL EZDİĞİMİZ STRİNG() METODUNU ÇALIŞTIRIYOR Kİ? metodu çağırmadık?
                //lstKitaplar.Items.Add(kitap.KitapAdi);
            }
        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CRUD;  CREATE READ UPDATE CLEAN
            var secilenEleman = (Kitap)lstKitaplar.SelectedItem; //cast ettik çünkü listbox'ın elemanları object türündedir.

            txtKitapAdi.Text = secilenEleman.KitapAdi;
            txtYazarAdi.Text = secilenEleman.Yazar;
            txtYazarAdi.Text = secilenEleman.Fiyat.ToString();
            txtYayinevi.Text = secilenEleman.Yayinevi;
            txtSayfaSayisi.Text = secilenEleman.SayfaSayisi.ToString();
            dtpBasimTarihi.Value = secilenEleman.BasimTarihi;
            cmbTuru.SelectedItem = secilenEleman.ToString();
        }

        // Ödev: Ögrenci kayıt ekranı oluştur. Ödevlerinizi rabianur@outlook.com adresine zip olarak mail atınız. DONE!
    }
}
