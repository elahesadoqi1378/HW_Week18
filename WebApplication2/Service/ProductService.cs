using WebApplication2.Contracts.Repository;
using WebApplication2.Contracts.Service;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService()
        {
            productRepository = new ProductRepository();
        }

        public void Create(Productt product)
        {
            productRepository.Create(product);
        }

        public Productt Get(int id)
        {
            return productRepository.Get(id);
        }

        public List<Productt> GetAll()
        {
            return productRepository.GetAll();
        }

        public void update(int id, Productt product)
        {
            productRepository.update(id, product);
        }

        public void Delete(int id)
        {
            productRepository.Delete(id);
        }
    }

}
