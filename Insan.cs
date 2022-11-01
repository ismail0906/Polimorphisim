using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Polimorphisim
{
    public  class Insan
    {
        public int KimlikNo { get; set; }
        public virtual void Dusunce() 
        {
            Console.WriteLine("İnsan Düşünür");
        }
    }

    // virtual==> virtual üyeler alt sınıflar tarafından ezilebilen ve base üzerinden çalıştırıldığında alt sınıf üyeleri gibi çalışabilen üyelerdir..
}

