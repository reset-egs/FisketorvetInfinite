using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Username { get; set; }
   
        public List<User> Users { get; set; } = new List<User>();

        [BindProperty]
        public User User { get; set; }
        
        public void OnGet()
        {
            Username = HttpContext.Session.GetString("username");
        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToPage("Index");
        }
    }
}
