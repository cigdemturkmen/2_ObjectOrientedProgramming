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

        private void KitapKayitSayfasi_Load(object sender, EventArgs e)
        {
            //ya da türler dizisi oluşturup AddRange metodu ile ekleyebiliirsin.
            cmbTuru.Items.Add("Gerilim");
            cmbTuru.Items.Add("Romantik");
            cmbTuru.Items.Add("Fantastik");
            cmbTuru.Items.Add("Macera");
            cmbTuru.Items.Add("Roman");
        }

        Kitap[] kitaplar = new Kitap[0];

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kitap adı, yazar ad soyad, fiyatı, türü, yayınevi, Basım tarihi, sayfa sayısı bilgilerini alarak kitap[] içinde tutan bir uygulama yapalım.

            Kitap kitap = new Kitap();
            txtKitapAdi.Text = kitap.KitapAdi;
            txtYayinevi.Text = kitap.Yayinevi;
            txtFiyat.Text = kitap.Fiyat.ToString();
            cmbTuru.SelectedItem.ToString();
            txtYayinevi.Text = kitap.Yayinevi;
            dtpBasimTarihi.Value = kitap.BasimTarihi;
            txtSayfaSayisi.Text = kitap.SayfaSayisi.ToString();

            Array.Resize(ref kitaplar, kitaplar.Length + 1);
            kitaplar[kitaplar.Length - 1] = kitap;

            MessageBox.Show("Kitap başarıyla kaydedilmiştir.");

            FormuTemizle();
        }

        /*kaydetme işlemi tamamlandıktan sonra ya da temizleme butonuna basıldığında textbox, combobox, datepicker'ı temizleyecek bir metot yazın.*/

        private void FormuTemizle()
        {
            //txtKitapAdi.Clear();
            //txtYazarAdi.Clear();
            //txtYayinevi.Clear();
            //txtFiyat.Clear();
            //txtSayfaSayisi.Clear();

            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    var txt = (TextBox)item;
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

        //kitap[] içindekileri listbox'a ekleyelim.
        private void btnKitaplarıListele_Click(object sender, EventArgs e)
        {
            foreach (var item in kitaplar)
            {
                lstKitaplar.Items.Add(item);
                //lstKitaplar.Items.Add(kitap.KitapAdi);
            }
        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CRUD; CLEAN READ UPDATE 
            var secilenEleman = (Kitap)lstKitaplar.SelectedItem; //cast ettik

            txtKitapAdi.Text = secilenEleman.KitapAdi;
            txtYazarAdi.Text = secilenEleman.Yazar;
            txtYazarAdi.Text = secilenEleman.Fiyat.ToString();
            txtYayinevi.Text = secilenEleman.Yayinevi;
            txtSayfaSayisi.Text = secilenEleman.SayfaSayisi.ToString();
            dtpBasimTarihi.Value = secilenEleman.BasimTarihi;
            cmbTuru.SelectedItem = secilenEleman.ToString();
        }

        // Ödev: Ögrenci kayıt ekranı oluştur. Ödevlerinizi rabianur@outlook.com adresine zip olarak mail atınız.
    }
}
