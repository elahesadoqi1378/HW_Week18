using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebApplication2.Contracts.Service;
using WebApplication2.Models;
using WebApplication2.Service;

namespace WebApplication2.Models.Product
{
    public class IndexModel : PageModel
        {
            private readonly IProductService productService;

            public IEnumerable<Productt> Products { get; private set; }

            public IndexModel()
            {
            productService = new ProductService();
            }

        public void OnGet()
        {
            Products = productService.GetAll(); 
        }
    }
    

}




