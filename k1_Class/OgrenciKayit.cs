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
    public partial class OgrenciKayit : Form
    {
        public OgrenciKayit()
        {
            InitializeComponent();
        }

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
            //Combobox itemları yazıldı.

            //Cinsiyetler
            cmbCinsiyet.Items.Add("Kadın");
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Belirtmek istemiyorum");
            cmbCinsiyet.Items.Add("Özel");

            //Kan Grupları
            cmbKanGrubu.Items.Add("0 Rh+");
            cmbKanGrubu.Items.Add("0 Rh-");
            cmbKanGrubu.Items.Add("A Rh+");
            cmbKanGrubu.Items.Add("A Rh-");
            cmbKanGrubu.Items.Add("B Rh+");
            cmbKanGrubu.Items.Add("B Rh-");
            cmbKanGrubu.Items.Add("AB Rh+");
            cmbKanGrubu.Items.Add("AB Rh-");

            //Bolumler
            string[] bolumler =
                {
                "Beden Eğitimi ve Spor Bölümü","Bilgisayar Mühendisliği Bölümü","Bilgisayar ve Öğretim Teknolojileri Eğitimi Bölümü","Biyolojik Bilimler Bölümü","Çevre Mühendisliği Bölümü","Deniz Bilimleri Enstitüsü","Eğitim Bilimleri Bölümü","Elektrik Programı","Elektrik ve Elektronik Mühendisliği Bölümü","Endüstri Mühendisliği Bölümü","Endüstriyel Elektronik Programı","Endüstriyel Otomasyon Programı","Endüstriyel Tasarım Bölümü","Enformatik Enstitüsü","Felsefe Bölümü","Fen Bilimleri Enstitüsü","Fizik Bölümü","Gıda Mühendisliği Bölümü","Havacılık ve Uzay Mühendisliği Bölümü","İktisat Bölümü","İnşaat Mühendisliği Bölümü","İstatistik Bölümü","İşletme Bölümü","Jeoloji Mühendisliği Bölümü","Kaynak Teknolojisi Programı","Kimya Bölümü","Kimya Mühendisliği Bölümü","Maden Mühendisliği Bölümü","Makina Mühendisliği Bölümü","Matematik Bölümü","Matematik ve Fen Bilimleri Eğitimi Bölümü","Metalurji ve Malzeme Mühendisliği Bölümü","Mimarlık Bölümü","Modern Diller Bölümü","Mühendislik Bilimleri Bölümü","Müzik ve Güzel Sanatlar Bölümü","Petrol ve Doğal Gaz Mühendisliği Bölümü","Psikoloji Bölümü","Siyaset Bilimi ve Kamu Yönetimi Bölümü","Sosyal Bilimler Enstitüsü","Sosyoloji Bölümü","Şehir ve Bölge Planlama Bölümü","Tarih Bölümü","Teknik Programlar Bölümü","Temel Eğitim Bölümü","Temel İngilizce Bölümü","Türk Dili Bölümü","Uluslararası İlişkiler Bölümü","Uygulamalı Matematik Enstitüsü","Yabancı Diller Eğitimi Bölümü"};

            cmbBolum.Items.AddRange(bolumler);
        }

        //Formu temizlemek için fonksiyon oluşturuldu.
        private void FormuTemizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    var textBox = (TextBox)item;
                    textBox.Clear();
                }
                else if (item is ComboBox)
                {
                    var comboBox = (ComboBox)item;
                    comboBox.SelectedIndex = -1;
                }
                else if (item is DateTimePicker)
                {
                    var dateTimePicker = (DateTimePicker)item;
                    dateTimePicker.Value = DateTime.Now;
                }
            }
        }

        //Cinsiyette "Özel" seçilirse başka bir textbox aktif hale gelecek.
        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenCinsiyet = cmbCinsiyet.SelectedIndex;

            if (secilenCinsiyet == 3)
            {
                txtCustomCinsiyet.Enabled = true;
                lblOzel.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        //Ogrenci kayıt butonu ve kayıtların kaydolacağı dizi oluşturuldu.
        Ogrenci2[] ogrenciler = new Ogrenci2[0];

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci2 ogrenci = new Ogrenci2();

            //Textbox'lardan birisi boşsa uyarı versin ve kaydetmesin.
            foreach (var item in this.Controls)
            {  
                if (item is TextBox && item!=txtCustomCinsiyet)
                {
                    var textbox = (TextBox)item;
                    if (textbox.Text =="")
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                        return;
                    }
                }
            }

            //Drop down listlerde bir şey seçilmemişse uyarı versin ve kaydetmesin.
            foreach (var item in this.Controls)
            {
                if (item is ComboBox)
                {
                    var comboBox = (ComboBox)item;
                    if (comboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                        return;
                    }  
                }
            }
            
            ogrenci.Ad = txtAd.Text;
            ogrenci.Soyad = txtSoyad.Text;
            ogrenci.DogumTarihi = dtpDogumTarihi.Value;
            ogrenci.Adres = txtAdres.Text;
            ogrenci.OzelCinsiyet = txtCustomCinsiyet.Text;
            ogrenci.Bolum = cmbBolum.SelectedItem.ToString();
            ogrenci.Cinsiyet = cmbBolum.SelectedItem.ToString();
            ogrenci.KanGrubu = cmbKanGrubu.SelectedItem.ToString();

            try
            {
                ogrenci.TcNo = txtTcNo.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                ogrenci.TelefonNo = txtTelefonNo.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Array.Resize(ref ogrenciler, ogrenciler.Length + 1);
            ogrenciler[ogrenciler.Length - 1] = ogrenci;

            MessageBox.Show("Kayıt işlemi başarıyla gerçekleştirilmiştir.");

            FormuTemizle();
        }

        //Formu temizlemek için ayrı bir buton.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        //En son kayıt edilen öğrenciye ulaşmak için bir buton.
        private void btnEnSonKayit_Click(object sender, EventArgs e)
        {
            var enSonKayit = ogrenciler[ogrenciler.Length - 1];

            txtAd.Text = enSonKayit.Ad;
            txtSoyad.Text = enSonKayit.Soyad;
            txtTcNo.Text = enSonKayit.TcNo;
            txtTelefonNo.Text = enSonKayit.TelefonNo;
            txtAdres.Text = enSonKayit.Adres;
            dtpDogumTarihi.Value = enSonKayit.DogumTarihi;
            cmbCinsiyet.SelectedItem = enSonKayit.Cinsiyet;
            txtCustomCinsiyet.Text = enSonKayit.OzelCinsiyet;
            cmbKanGrubu.SelectedItem = enSonKayit.KanGrubu;
            cmbBolum.SelectedItem = enSonKayit.Bolum;
        }
    }
}
