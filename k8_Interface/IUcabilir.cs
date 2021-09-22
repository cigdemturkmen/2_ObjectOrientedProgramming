using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    interface IUcabilir
    {
        double UcabilecegiMaxYukseklik { get; set; }
        UzunlukBirimi UcabilecegiMaxYukseklikBirimi { get; set; }

        void Uc();
    }
}
