using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k6_Abstraction
{
    /*
    abstract anahtar kelimesi, sınıfın önüne konulursa bu sınıftan instance alınmasını engeller. Bu sınıfı soyut yapar.
    abstract bir metot ya da property yaparsanız, içinde oldukları sınıfı da abstract yapmanız gerekir.
    abstact olarak tanımlanan bir metotun gövdesi tanımlanmaz, yani {} konmaz! Abstract sınıfı miras alan sınıfların içinde bu metotun gövdesi tanımlanır.(zorunlu polymorphism)
    abstract keywordü önüne geldiği nesneyi soyutlaştırıyor.
    abstract sınıflardan instance alınamaz. Çünkü bu sanal bir nesnedir.
     
    */
    abstract class Urun
    {
        public double Fiyat { get; set; }

        public abstract double KdvDahilFiyatHesapla();
        //{
        // //gövde'yi yazmıyoruz abstract sınıflarda.
        //}
        

    }
}
