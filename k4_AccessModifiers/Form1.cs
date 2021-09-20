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
        /*Erişim Belirleyiciler(Access Modifiers): Class veya class elemanlarının başka bir class içinde kullanılması için erişimine izin veren anahtar kelimelerdir.
         * 1.public: Bir sınıfı ya da sınıf elemanlarını public tanımlarsak, bunları hem proje içinde başka sınıflardan hem de farklı bir projedeki sınıflar  içinden erişime açık olur. Eğer bir proje içindeki sınıfın başka bir projeden görünür olm istiyosanız öcelikle public yapınız sonra kullanmak istiyorsanız projeye referans olarak ekleyiniz. ardından using ile namespace tanımlaması yaparak(o classın projesinin ismi) kullanabilirsiniz.
         * 2.internal: class veya class elemanları internal olarak işaretlenirse bu elemanlara veya sınıfa sadece bulunduğu proje içinden erişilebilir. classların önüne bir şey yazılmazsa defaultta internal olarak görülür. 
         * 3.protected: eğer sınıf içindeki elemanlar protected olarak işaretlenirse miras alınan sınıf içinden görünür  olurlar.Sınıflar protected olarak işaretlenemezler.
         * 4.protected internal: hem protected'in hem internal'ın özelliklerini gösterir.
         * 5.private: class'lara private yazamasınız. eğer class elemanlarına erişim belirleyici vermezseniz default olarak private davranır ve sadece o sınıf içinden erişilebilir olur.
         * Bir projeye başka bir projeyi referans veriyorsak sürümleri eşleşmelidir. eğer referanslar kısmında sarı bir ünlem görüyorsak bu sürümlerin eşleşmediğini gösterir. ikisini eşitlersek sorun düzelir.
         * 
         * classların başına sadece public veya internal gelebilir.
         */
        public Form1()
        {
            InitializeComponent();
            
        }
    }
}
