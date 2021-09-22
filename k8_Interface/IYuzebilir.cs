using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    interface IYuzebilir //interface'in önüne erişim belirleyici yazılabilir ama bu class içindekilere erişim belirleyici yazılamaz!
    {
        double MaxInebilecegiDerinlik { get; set; }
        UzunlukBirimi Birimi { get; set; }
        void Swim();
        //{
        //    //
        //}
        
    }
}
