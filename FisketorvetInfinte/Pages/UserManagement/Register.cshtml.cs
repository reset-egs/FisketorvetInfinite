using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User User { get; set; } = new User();

        public string Role { get; set; }

        public IUserService UserService { get; set; }

        public RegisterModel(IUserService service)
        {
            UserService = service;
        }

        public void OnGet()
        {
            Role = HttpContext.Session.GetString("role");
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                UserService.AddUser(User);
                return RedirectToPage("../Index");
            }
            return Page();
        }
    }
}
