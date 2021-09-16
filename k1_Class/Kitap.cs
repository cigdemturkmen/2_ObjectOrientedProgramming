using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_Class
{
    class Kitap
    {
        string _kitapAdi;
        string _yazar;
        double _fiyat;
        string _turu;       
        string _yayinevi;
        int _sayfaSayisi;
        

        public string KitapAdi
        {
            get { return _kitapAdi; }
            set { _kitapAdi = value; }
        }
        public string Yazar
        {
            get { return _yazar; }
            set { _yazar = value; }
        }
        public double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        public string Turu
        {
            get { return _turu; }
            set { _turu = value; }
        }
        public string Yayinevi
        {
            get { return _yayinevi; }
            set { _yayinevi = value; }
        }
        DateTime _basimTarihi;
        public DateTime BasimTarihi
        {
            get { return _basimTarihi; }
            set { _basimTarihi = value; }
        }
        public int SayfaSayisi
        {
            get { return _sayfaSayisi; }
            set { _sayfaSayisi = value; }
        }

        public override string ToString()
        {
            //sadece gösterim yaparken;
            return this.KitapAdi; //namespaceadi.sinifAdi (base'deki böyle çalışır) > k1.Class.Kitap
            //return this.KitapAdi + " "+ this.Yayinevi;
        }
    }
}
