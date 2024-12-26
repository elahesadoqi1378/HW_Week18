using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Contracts.Service;
using WebApplication2.Service;

namespace WebApplication2.Pages.Product
{
    public class CreateModel : PageModel
    {

        private readonly IProductService productService;
        private readonly ICategoryService categoryService;


        [BindProperty]
        public WebApplication2.Models.Productt NewProduct { get; set; }

        public List<WebApplication2.Models.Categoryy> Categories { get; private set; }

        public CreateModel()
        {
            productService = new ProductService();
            categoryService = new CategoryService();
        }

        public void OnGet()
        {
            Categories = categoryService.GetAll();
        }

        public IActionResult OnPost()
        {
           
            Console.WriteLine($"Name: {NewProduct.Name}, Price: {NewProduct.Price}, CategoryId: {NewProduct.CategoryId}");
            productService.Create(NewProduct);
            return RedirectToPage("/Product/Index");
        }


    }
}
