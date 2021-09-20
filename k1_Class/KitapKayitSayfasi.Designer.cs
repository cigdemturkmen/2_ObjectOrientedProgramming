
namespace k1_Class
{
    partial class KitapKayitSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.dtpBasimTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKitaplarıListele = new System.Windows.Forms.Button();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(257, 315);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 42);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yayınevi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Basım Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sayfa Sayısı";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(122, 12);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(250, 22);
            this.txtKitapAdi.TabIndex = 8;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(122, 51);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(250, 22);
            this.txtYazarAdi.TabIndex = 9;
            // 
            // cmbTuru
            // 
            this.cmbTuru.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTuru.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.Location = new System.Drawing.Point(122, 134);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(250, 24);
            this.cmbTuru.TabIndex = 10;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(122, 94);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(250, 22);
            this.txtFiyat.TabIndex = 11;
            // 
            // dtpBasimTarihi
            // 
            this.dtpBasimTarihi.Location = new System.Drawing.Point(122, 223);
            this.dtpBasimTarihi.Name = "dtpBasimTarihi";
            this.dtpBasimTarihi.Size = new System.Drawing.Size(250, 22);
            this.dtpBasimTarihi.TabIndex = 12;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(122, 179);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(250, 22);
            this.txtYayinevi.TabIndex = 13;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(122, 262);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(250, 22);
            this.txtSayfaSayisi.TabIndex = 14;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(122, 315);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(115, 42);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKitaplarıListele
            // 
            this.btnKitaplarıListele.Location = new System.Drawing.Point(460, 12);
            this.btnKitaplarıListele.Name = "btnKitaplarıListele";
            this.btnKitaplarıListele.Size = new System.Drawing.Size(213, 28);
            this.btnKitaplarıListele.TabIndex = 16;
            this.btnKitaplarıListele.Text = "Kitapları Listele";
            this.btnKitaplarıListele.UseVisualStyleBackColor = true;
            this.btnKitaplarıListele.Click += new System.EventHandler(this.btnKitaplarıListele_Click);
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.ItemHeight = 16;
            this.lstKitaplar.Location = new System.Drawing.Point(460, 51);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(331, 308);
            this.lstKitaplar.TabIndex = 17;
            this.lstKitaplar.SelectedIndexChanged += new System.EventHandler(this.lstKitaplar_SelectedIndexChanged);
            // 
            // KitapKayitSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 744);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.btnKitaplarıListele);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.dtpBasimTarihi);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.cmbTuru);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Name = "KitapKayitSayfasi";
            this.Text = "KitapKayitSayfasi";
            this.Load += new System.EventHandler(this.KitapKayitSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.DateTimePicker dtpBasimTarihi;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKitaplarıListele;
        private System.Windows.Forms.ListBox lstKitaplar;
    }
}