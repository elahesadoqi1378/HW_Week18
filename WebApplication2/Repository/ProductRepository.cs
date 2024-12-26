using Microsoft.EntityFrameworkCore;
using WebApplication2.Contracts.Repository;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class ProductRepository : IProductRepository
    {
        AppDBContext appDBContext;
        public ProductRepository()
        {
            appDBContext = new AppDBContext();
        }
        public void Create(Productt product)
        {
            appDBContext.Products.Add(product);
          var result =  appDBContext.SaveChanges();

            Console.WriteLine($"Rows affected: {result}");
        }

        public void Delete(int id)
        {
             var product = appDBContext.Products.FirstOrDefault(x=>x.Id==id);
            if (product != null)
            {
                appDBContext.Products.Remove(product);
               appDBContext.SaveChanges();
            }
        }

        public Productt Get(int id)
        {
            var product= appDBContext.Products.FirstOrDefault(x => x.Id == id);
            if(product is not null)
            {
                return product;
            }
            else
            {
                throw new Exception("product not found" + product.Id);
            }
        }

        public List<Productt> GetAll()
        {
            return appDBContext.Products.ToList();
        }

        public void update(int id, Productt product)
        {
            var existingProduct = appDBContext.Products.FirstOrDefault(x => x.Id == id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.CategoryId = product.CategoryId;
                appDBContext.SaveChanges();
            }
        }
    }
}
