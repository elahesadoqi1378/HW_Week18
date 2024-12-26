using WebApplication2.Models;

namespace WebApplication2.Contracts.Service
{
    public interface ICategoryService
    {
        void Create(Categoryy category);
        List<Categoryy> GetAll();
        Categoryy Get(int id);
        void Update(int id, Categoryy category);
        void Delete(int id);
    }
}

