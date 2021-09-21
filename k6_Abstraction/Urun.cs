using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k6_Abstraction
{
    /*
    Abstract sınıfın önüne konulursa bu sınıftan instance alınmasını engeller.
    Abstract bir metot ya da property yaparsanız sınıfa da abstract eklemeniz gerekir.
    abstact olarak tanımlanan bir metotun gövdesi tanımlanmaz, yani {} konmaz! Miras alan sınıf içinde bu metotun gövdesi tanımlanır.(zorunlu polymorphism)
    Abstract keywordü önüne geldiği nesneyi soyutlaştırıyor.
    Abstract sınıflardan instance alınamaz. Çünkü bu sanal bir nesnedir.
     
    */
    abstract class Urun
    {
        public double Fiyat { get; set; }

        public abstract double KdvHesapla();
        //{
        // //gövde
        //}
        

    }
}
