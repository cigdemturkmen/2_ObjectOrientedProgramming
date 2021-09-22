namespace k7_Enum
{
    partial class Form2
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
            this.cmbEkmekTuru = new System.Windows.Forms.ComboBox();
            this.txtGramaj = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEkmekTuru
            // 
            this.cmbEkmekTuru.FormattingEnabled = true;
            this.cmbEkmekTuru.Location = new System.Drawing.Point(71, 35);
            this.cmbEkmekTuru.Name = "cmbEkmekTuru";
            this.cmbEkmekTuru.Size = new System.Drawing.Size(268, 21);
            this.cmbEkmekTuru.TabIndex = 0;
            // 
            // txtGramaj
            // 
            this.txtGramaj.Location = new System.Drawing.Point(71, 88);
            this.txtGramaj.Name = "txtGramaj";
            this.txtGramaj.Size = new System.Drawing.Size(268, 20);
            this.txtGramaj.TabIndex = 1;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(71, 62);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(268, 20);
            this.txtFiyat.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(264, 114);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 330);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtGramaj);
            this.Controls.Add(this.cmbEkmekTuru);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEkmekTuru;
        private System.Windows.Forms.TextBox txtGramaj;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnKaydet;
    }
}