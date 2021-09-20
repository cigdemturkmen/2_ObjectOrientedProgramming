using OBS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k4_AccessModifiers
{//Projelere ayırarak kod yazmaya katmanlı mimari denir. OBD.UI, OBS.DATA, OBS.BLL (OBS:öğr bil sist örneği)
    public partial class Form1 : Form
    {
        /*
        
        Erişim Belirleyiciler(Access Modifiers): 
        Class veya class elemanlarının başka bir class içinde kullanılması için erişimine izin veren anahtar kelimelerdir.

         * 1.public:(solution içindeki tüm projelerden) Bir sınıfı ya da sınıf elemanlarını public tanımlarsak, bunlar hem proje içinde başka sınıflarda hem de farklı bir projedeki sınıflar içinde erişime açık olur. Eğer bir proje içindeki sınıfın başka bir projeden görünür olmasını istiyosanız öcelikle PUBLIC YAPINIZ sonra kullanmak istiyorsanız projeye REFERANS OLARAK EKLEYİNİZ. Ardından USING İLE NAMESPACE TANIMLAMASI yaparak(o classın projesinin ismi) kullanabilirsiniz.

         * 2.internal:(kendi projesinde her yerden) Class veya class elemanları internal olarak işaretlenirse bu elemanlara veya bu class'a sadece bulunduğu proje içinden erişilebilir. classların önüne bir şey yazılmazsa defaultta internal olarak görülür. 

         * 3.protected:(sadece inheritance verdiği sınıfların içinden) eğer sınıf içindeki elemanlar protected olarak işaretlenirse miras alınan sınıf içinden görünür  olurlar.Sınıflar protected olarak işaretlenemezler.

         * 4.protected internal: hem protected'in hem internal'ın özelliklerini gösterir.(yani, kendi projesinde her yerden ve inheritance verdiği sınıfların içinden ulaşılabilir.)

         * 5.private: class'lara private yazamasınız. eğer class elemanlarına erişim belirleyici vermezseniz default olarak private davranır ve sadece o sınıf içinden erişilebilir olur.

         * Bir projeye başka bir projeyi referans veriyorsak sürümleri eşleşmelidir. eğer referanslar kısmında sarı bir ünlem görüyorsak bu sürümlerin eşleşmediğini gösterir. ikisini eşitlersek sorun düzelir.
         
         !!!Classların başına sadece public veya internal gelebilir!!! Bir şey yazılmazsa default olarak internal olur.
         */
        public Form1()
        {
            InitializeComponent();
            
        }
    }
}
