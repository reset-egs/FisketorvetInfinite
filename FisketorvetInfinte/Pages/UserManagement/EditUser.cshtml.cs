using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages.UserManagement
{
    public class EditUserModel : PageModel
    {
        [BindProperty]
        public User User { get; set; } = new User();

        public IUserService UserService { get; set; }

        public EditUserModel(IUserService service)
        {
            UserService = service;
        }

        public void OnGet(string username)
        {
            User = UserService.GetUser(username);
        }

        public IActionResult OnPost()
        {
            UserService.UpdateUser(User);
            return RedirectToPage("./AllUsers");
        }
    }
}
