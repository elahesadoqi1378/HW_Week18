using Microsoft.EntityFrameworkCore;
using WebApplication2.Contracts.Repository;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        AppDBContext appDBContext;
        public CategoryRepository()
        {
            appDBContext = new AppDBContext();
        }
        public void Create(Categoryy category)
        {
            appDBContext.Categories.Add(category);
            appDBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = appDBContext.Categories.FirstOrDefault(x=>x.Id==id);
            if (category != null)
            {
                appDBContext.Categories.Remove(category);
                appDBContext.SaveChanges();
            }
        }

        public Categoryy Get(int id)
        {
            var category = appDBContext.Categories.FirstOrDefault(x => x.Id == id);
            if (category == null) throw new Exception($"Category with ID {id} not found.");
            return category;
        }

        public List<Categoryy> GetAll()
        {
            return appDBContext.Categories.ToList();
        }

        public void update(int id, Categoryy category)
        {
            var existingCategory = Get(id);
            existingCategory.Name = category.Name;
            appDBContext.SaveChanges();
        }
    }
}
