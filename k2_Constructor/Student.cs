using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_Constructor
{
    class Student
    {
        #region Constructor
        //public oluşturulur! Constructor metodu bir classtan instance alırken kullanılır(çağırılır).Random rnd = new Random();

        public Student()
        {
            //tanımlanmazsa, arkada otomatik olarak tanımlanır zaten. buraya ogrencinin default özellikleri de yazılabilir.
        }

        public Student(string name, string surname, string tcnk)
        {
            this.Name = name; //buradaki parametreler yeni oluşturulan bir instance'ın property'leri olacak.
            this.Surname = surname;
            this.TCKN = tcnk;
        }
        #endregion

        #region Properties

        //private string _name;
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        //Yukarıdaki gösterimin kapalı hali şu şekildedir:

        public string Name { get; set; } //_name field'ı arkada otomatik oluşturulur bu gösterimde. Artık bunu kullan.

        public string Surname { get; set; }

        public string TCKN { get; set; }
        #endregion
    }
}
