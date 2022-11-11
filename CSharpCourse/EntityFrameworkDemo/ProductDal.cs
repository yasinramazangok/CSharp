using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext()) // ETradeContext pahalı bir nesnedir, bellekte çok fazla yer kaplar.
            {
                // using ile kullanılmasının sebebi, Garbage Collector'ü beklemeden işi biten nesneyi bellekten dispose etmeyi sağladığı içindir.
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext()) // ETradeContext pahalı bir nesnedir, bellekte çok fazla yer kaplar.
            {
                // using ile kullanılmasının sebebi, Garbage Collector'ü beklemeden işi biten nesneyi bellekten dispose etmeyi sağladığı içindir.
                return context.Products.Where(p=>p.Name.Contains(key)).ToList(); // Burada direkt olarak veritabanı sorgu atıyoruz.
                // Çok veri olduğunda bu şekilde direkt olarak veritabanına sorgu atmak daha performanslıdır.
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext()) // ETradeContext pahalı bir nesnedir, bellekte çok fazla yer kaplar.
            {
                // using ile kullanılmasının sebebi, Garbage Collector'ü beklemeden işi biten nesneyi bellekten dispose etmeyi sağladığı içindir.
                return context.Products.Where(p => p.UnitPrice>=min && p.UnitPrice<=max).ToList(); // Burada direkt olarak veritabanı sorgu atıyoruz.
                // Çok veri olduğunda bu şekilde direkt olarak veritabanına sorgu atmak daha performanslıdır.
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext()) // ETradeContext pahalı bir nesnedir, bellekte çok fazla yer kaplar.
            {
                // using ile kullanılmasının sebebi, Garbage Collector'ü beklemeden işi biten nesneyi bellekten dispose etmeyi sağladığı içindir.
                var result = context.Products.FirstOrDefault(p => p.Id == id); // SingleOrDefault() metodu ise sorguya uyan 1'den fazla data bulursa hata verir.
                return result;
                
                // Çok veri olduğunda bu şekilde direkt olarak veritabanına sorgu atmak daha performanslıdır.
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext()) 
            {
                context.Products.Add(product); // Bu kod yorum satırındaki gibi de yazılabilirdi.
                /*
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                */
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
