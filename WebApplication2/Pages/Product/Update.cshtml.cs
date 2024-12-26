using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Contracts.Service;
using WebApplication2.Models;
using WebApplication2.Service;

namespace WebApplication2.Pages.Product
{
    public class UpdateModel : PageModel
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        [BindProperty]
        public WebApplication2.Models.Productt UpdatedProduct { get; set; }

        public List<WebApplication2.Models.Categoryy> Categories { get; private set; }


        public UpdateModel()
        {
            productService = new ProductService();
            categoryService = new CategoryService();
        }
        public IActionResult OnGet(int id)
        {
            UpdatedProduct = productService.Get(id);
            if (UpdatedProduct == null)
            {
                return RedirectToPage("/Error"); 
            }

            Categories = categoryService.GetAll();
            return Page();
        }

        public IActionResult OnPost()
        {
            var existingProduct = productService.Get(UpdatedProduct.Id); 
            if (existingProduct == null)
            {
                return NotFound("Product not found for update.");
            }

            productService.update(UpdatedProduct.Id, UpdatedProduct);
            return RedirectToPage("/Product/Index");
        }
    }
}





