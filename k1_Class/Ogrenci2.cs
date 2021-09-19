using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_Class
{
    class Ogrenci2
    {
        string _ad;
        string _soyad;
        string _tcNo;
        DateTime _dogumTarihi;
        string _cinsiyet;
        string _ozelCinsiyet;
        string _bolum;
        string _kanGrubu;
        string _telefonNo;
        string _adres;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public string TcNo
        {
            get { return _tcNo; }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception("TC kimlik numarası 11 haneli olmalıdır.");
                }
                _tcNo = value; 
            }
        }

        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }

        public string Cinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }

        public string OzelCinsiyet
        {
            get { return _ozelCinsiyet; }
            set { _ozelCinsiyet = value; }
        }

        public string Bolum
        {
            get { return _bolum; }
            set { _bolum = value; }
        }

        public string KanGrubu
        {
            get { return _kanGrubu; }
            set { _kanGrubu = value; }
        }

        public string TelefonNo
        {
            get { return _telefonNo; }
            set
            {
                if (value.StartsWith("0") || value.Length != 10)
                {
                    throw new Exception("Telefon numarasını başında 0 olmadan 10 haneli olacak şekilde yazınız.");
                    //System.Windows.Forms.MessageBox.Show("Test"); ??
                }
                _telefonNo = value; 
            }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
    }
}
