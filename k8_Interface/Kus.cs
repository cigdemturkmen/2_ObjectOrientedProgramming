using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    abstract class Kus
    {
        public string TuyRengi { get; set; }
        public double GagaBoyu { get; set; }
        public UzunlukBirimi GagaBoyuBirimi { get; set; }
        public double KanatUzunlugu { get; set; }
        public UzunlukBirimi KanatUzunlukBirimi { get; set; }
        public bool AyagiPerdeliMi { get; set; }


        //void Fly()
        //{
        //çocuklarda ortak olmadığı için burada tanımlanamadı. Bu yetenekleri kazandırmak için interface ypcz.
        //}

        //void Swim()
        //{
        //çocuklarda ortak olmadığı için burada tanımlanamadı. Bu yetenekleri kazandırmak için interface ypcz.
        //}
    }
}
