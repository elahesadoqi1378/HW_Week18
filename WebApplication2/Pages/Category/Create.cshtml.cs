using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Contracts.Service;
using WebApplication2.Models;

namespace WebApplication2.Pages.Category
{
    public class CreateModel : PageModel
    {
        private readonly ICategoryService categoryService;

        [BindProperty]
        public Categoryy NewCategory { get; set; }

        public CreateModel(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            categoryService.Create(NewCategory);
            return RedirectToPage("/Category/Index");
        }
    }

}
