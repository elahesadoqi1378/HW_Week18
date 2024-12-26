using WebApplication2.Contracts.Repository;
using WebApplication2.Contracts.Service;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }

        public void Create(Categoryy category)
        {
            categoryRepository.Create(category);
        }

        public Categoryy Get(int id)
        {
            return categoryRepository.Get(id);
        }

        public List<Categoryy> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public void Update(int id, Categoryy category)
        {
            categoryRepository.update(id, category);
        }

        public void Delete(int id)
        {
            categoryRepository.Delete(id);
        }
    }

}
