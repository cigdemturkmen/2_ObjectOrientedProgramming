using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k7_Enum
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Ekmek e1 = new Ekmek();
            //e1.Gramaj = 100;
            //e1.Tur = EkmekTuru.BeyazEkmek;
            //e1.BirimFiyatı = 1.50;

            //combobox'ın içine EkmekTuru enum'ının içindeki degerlerle dolduralım.
            string[] ekmekTurleri = Enum.GetNames(typeof(EkmekTuru));

            cmbEkmekTuru.Items.AddRange(ekmekTurleri);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var e2 = new Ekmek();
            e2.Gramaj = Convert.ToDouble(txtGramaj.Text);
            e2.BirimFiyatı = Convert.ToDouble(txtFiyat.Text);
            var secilenTur = cmbEkmekTuru.SelectedItem.ToString();

            e2.Tur = secilenTur; //Cannot implicitly convert string to k7_Enum.EkmekTuru

            //1.yöntem
            switch (secilenTur)
            {
                case "BeyazEkmek":
                    e2.Tur = EkmekTuru.BeyazEkmek;
                    break;
                case "CavdarEkmegi":
                    e2.Tur = EkmekTuru.CavdarEkmegi;
                    break;
                default:
                    break;
                    //tüm enum değerleri için tek tek yazılması gerekir. uzun enumlar için iyi bir yöntem değil. mesela iller.
            }

            //2.yöntem
            var secilenEkmekTuruEnumi = (EkmekTuru)Enum.Parse(typeof(EkmekTuru), secilenTur);

            e2.Tur = secilenEkmekTuruEnumi;
        }
    }
}
