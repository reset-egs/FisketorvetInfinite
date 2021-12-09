using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages.UserManagement
{
    public class DeleteUserModel : PageModel
    {
        public IUserService _userService { get; set; }

        public DeleteUserModel(IUserService service)
        {
            _userService = service;
        }

        public string? Role { get; set; }

        [BindProperty(SupportsGet =true)]
        public User User { get; set; } = new User();
        public void OnGet(string username)
        {
            Role = HttpContext.Session.GetString("role");
            User = _userService.GetUser(username);
        }

        public IActionResult OnPost(string username)
        {
            User = _userService.FindUser(username);
            _userService.DeleteUser(User);
            return RedirectToPage("AllUsers");
        }
    }
}
