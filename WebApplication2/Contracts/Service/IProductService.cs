using WebApplication2.Models;

namespace WebApplication2.Contracts.Service
{
    public interface IProductService
    {
       List<Productt> GetAll();
       void Create(Productt product);
        Productt Get(int id);
        void update(int id, Productt product);
        void Delete(int id);

    }
}