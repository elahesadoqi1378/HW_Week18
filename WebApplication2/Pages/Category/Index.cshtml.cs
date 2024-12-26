using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Contracts.Service;
using WebApplication2.Models;
using WebApplication2.Service;

namespace WebApplication2.Models.Category
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryService categoryService;

        public List<Categoryy> Categories { get; private set; }

        public IndexModel()
        {
            categoryService = new CategoryService();
        }

        public void OnGet()
        {
            

            Categories = categoryService.GetAll();
           
        }
    }
}




//public class IndexModel : PageModel
//{
//    private readonly ICategoryService categoryService;

//    public List<Categoryy> Categories { get; private set; }

//    public IndexModel(ICategoryService categoryService)
//    {
//        this.categoryService = categoryService;
//    }

//    public void OnGet()
//    {
//        Categories = categoryService.GetAll();
//    }
//}
