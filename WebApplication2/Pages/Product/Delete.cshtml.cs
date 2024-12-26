using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Contracts.Service;
using WebApplication2.Models;
using WebApplication2.Service;

namespace WebApplication2.Pages.Product
{
    public class DeleteModel : PageModel
    {
        private readonly IProductService productService;

        [BindProperty]
        public Productt Product { get; set; }

        public DeleteModel()
        {
            productService = new ProductService();
        }

        public IActionResult OnGet(int id)
        {
            Product = productService.Get(id);
            if (Product == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            productService.Delete(id);
            return RedirectToPage("/Product/Index");
        }
    }

}
