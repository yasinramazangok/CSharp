using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        //public string firstName; // Bu şekilde bir tanımlama yapılırsa buna 'field' denir.
        public int id { get; set; } // Bu şekilde yapılan tanımlamaya ise 'property' denir. 

        private string _name;
        public string name
        {
            get
            {
                return "Değerli Arkadaşım " + _name;
            }
            set
            {
                _name = value;
            }
        } // Bu şekilde kullanıma 'implementasyon detayının gizlenmesi' yani 'ENCAPSULATION' denir.
        public string surname { get; set; }
        public string city { get; set; }
    }
}
