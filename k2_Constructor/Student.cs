using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_Constructor
{
    class Student
    {
        #region Constructor //public oluşturulur.
        public Student()
        {
            //tanımlanmazsa, arkada otomatik olarak tanımlanır zaten. buraya ogrencinin default özellikleri de yazılabilir.
        }

        public Student(string name, string surname, string tcnk)
        {
            this.Name = name;
            this.Surname = surname;
            this.TCKN = tcnk;
        }
        #endregion

        #region Properties

        public string Name { get; set; } //_name field'ı arkada otomatik oluşturulur. Bu gösterimin açık hali şu şekildeydi;TODO

        public string Surname { get; set; }

        public string TCKN { get; set; }
        #endregion
    }
}
