using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Models;
using WebApplication2;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Pages.Register
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext appDBContext;

        [BindProperty]
        public User NewUser { get; set; }

        public IndexModel()
        {
            appDBContext = new AppDBContext();
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            appDBContext.Users.Add(NewUser);
            appDBContext.SaveChanges();

            return RedirectToPage("Login");
        }
    }
}



