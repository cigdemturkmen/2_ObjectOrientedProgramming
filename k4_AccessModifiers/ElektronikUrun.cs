using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_AccessModifiers
{
    class ElektronikUrun
    {
        protected double GerilimDegeri { get; set; } = 100;//sadece çocukları erişebilir. //private olursa çocuğu da göremez.
        protected double Direnc { get; set; }
        public double Sicaklık { get; set; }
        double TuketilenGuc { get; set; } // default olarak private.

        void KwHesaplama()
        {
            var sonuc = TuketilenGuc * Direnc / GerilimDegeri;
        }
    }
}
