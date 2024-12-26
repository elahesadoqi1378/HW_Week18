using WebApplication2.Models;

namespace WebApplication2.Contracts.Repository
{
    public interface ICategoryRepository
    {
        void Create(Categoryy category);
        Categoryy Get(int id);
        List<Categoryy> GetAll();
        void update(int id, Categoryy category);
        void Delete(int id);
            
    }
}
