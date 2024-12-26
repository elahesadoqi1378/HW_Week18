using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Contracts.Service;
using WebApplication2.Models;

namespace WebApplication2.Pages.Category
{
    public class DeleteModel : PageModel
    {
        private readonly ICategoryService categoryService;

        public Categoryy Category { get; private set; }

        public DeleteModel(ICategoryService categoryService)
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

        public IActionResult OnPost(int id)
        {
            categoryService.Delete(id);
            return RedirectToPage("/Category/Index");
        }
    }

}
