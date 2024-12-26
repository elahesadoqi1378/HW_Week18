using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Models;
using WebApplication2;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Pages.Login
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext appDBContext;

        [BindProperty]
        public User LoggedInuser { get; set; }
        public IndexModel()
        {
            appDBContext = new AppDBContext();
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var user = appDBContext.Users.FirstOrDefault(x=>x.UserName ==LoggedInuser.UserName &&x.Password== LoggedInuser.Password);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return Page();
            }

            HttpContext.Session.SetString("Username", user.UserName);
            return RedirectToPage("/Index");
        }
    }
}






   

