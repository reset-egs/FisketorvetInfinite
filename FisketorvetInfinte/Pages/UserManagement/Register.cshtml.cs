using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User User { get; set; } = new User();

        public string Role { get; set; }

        public void OnGet()
        {
            Role = HttpContext.Session.GetString("role");
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                User.AddUser(User);
                return RedirectToPage("../Index");
            }
            return Page();
        }
    }
}
