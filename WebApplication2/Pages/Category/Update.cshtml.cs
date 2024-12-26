using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Contracts.Service;
using WebApplication2.Models;

namespace WebApplication2.Pages.Category
{
    public class UpdateModel : PageModel
    {
        private readonly ICategoryService categoryService;

        [BindProperty]
        public Categoryy Category { get; set; }

        public UpdateModel(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult OnGet(int id)
        {
            Category = categoryService.Get(id);
            if (Category == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
           

            categoryService.Update(Category.Id, Category);
            return RedirectToPage("/Category/Index");
        }
    }

}
