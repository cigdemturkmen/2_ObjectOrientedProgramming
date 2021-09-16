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

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            //Ogrenci sınıfı oluşturalım
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Bahar"; // set bloğu çalışır.
            //ogrenci1.Yas = 5; //hata verecek

            var yas = Convert.ToInt32(textBox1.Text);
            try
            {
                //ogrenci1.Yas = 11;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //ogrenci1.Yas = 11;

            MessageBox.Show(ogrenci1.Ad); //get bloğu çalışır
        }
    }
}
