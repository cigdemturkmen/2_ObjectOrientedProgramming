using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k3_Inheritance
{
    public partial class Form1 : Form
    {
        /*
         * Biyolojideki türlerin sınıflandırılması ve kalıtım vermesi gibi düşünebilirsiniz.
         * Base Sınıf: Kalıtım veren en üstteki sınıftır. Ebeveyn gibi düşün.
         * Derived Sınıf: Kalıtım alan, türetilmiş sınıftır. Ebeveynin çocuğu gibi düşün.
         * Amaç: tekrar tekrar property, metot vb. aynı elemanların tanımlanmasını önlemektir. 
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO burada oluşturduğun sınıfların kullanım denemelerini yap sonra.
        }
    }
}
