using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    // Aşağıda farklı nesneler içinde bir interface'in implemente edilmesine 'POLYMORPHISM' denilir.
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SqlServer added.");
        }

        public void Delete()
        {
            Console.WriteLine("SqlServer deleted.");
        }

        public void Update()
        {
            Console.WriteLine("SqlServer updated.");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated.");
        }
    }
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added.");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted.");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated.");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add(); // Buradan main metoduna gidilip değer verilir.
        }
    }
}
