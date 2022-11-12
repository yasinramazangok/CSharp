using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // Event'ler aslında delegate'ler ile yapılabilen işlemlerdir.
    // Bir event'e bir class'ı abone ettiğinizde o class için çalışacaktır aksi takdirde abonesi olmayan yapılar için event'ler çalışmazlar.
    public delegate void StockControl();
    public class Product
    {
        private int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }
        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                if (value <= 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} Stock amount: {0}",Stock,ProductName);
        }
    }
}
