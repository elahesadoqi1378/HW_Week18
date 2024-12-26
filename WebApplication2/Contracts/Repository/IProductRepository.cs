using WebApplication2.Models;

namespace WebApplication2.Contracts.Repository
{
    public interface IProductRepository
    {
        void Create(Productt product);
        Productt Get(int id);
        List <Productt> GetAll();
        void update(int id, Productt product);
        void Delete(int id);
    }
}
