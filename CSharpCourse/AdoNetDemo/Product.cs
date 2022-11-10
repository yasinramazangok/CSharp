using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public  decimal unitPrice { get; set; }
        public int stockAmount { get; set; }
    }
}
