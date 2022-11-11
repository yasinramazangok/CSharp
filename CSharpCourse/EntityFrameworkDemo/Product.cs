using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    // Entity Framework'de en temel unsur, veritabanındaki tablolara denk gelen nesnedir.
    public class Product
    {
        // Property isimleri PascalCase şeklinde yazılır.
        public int Id { get; set; }
        public string Name { get; set; }
        public  decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
