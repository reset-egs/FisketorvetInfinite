using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User User { get; set; } = new User();

        [BindProperty]
        public string Username { get; set; }

        public string Msg { get; set; }

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
            if (Username != null)
            {
                if (UserService.FindUser(Username) == null)
                {
                    User.Username = Username;

                    if (ModelState.IsValid)
                    {
                        User.Role = "user"; /*User should not be created without a role it will cause problems when logging in*/
                        UserService.AddUser(User);
                        return RedirectToPage("../Welcome");
                    }
                }
                else
                {
                    Msg = "User already exists.";
                    return Page();
                }
            }

            else
            {
                Msg = "You must provide a username";
                return Page();
            }
            return Page();
        }
    }
}
