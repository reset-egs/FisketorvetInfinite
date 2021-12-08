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

        public User? User { get; set; }
        public void OnGet(string user)
        {
            Role = HttpContext.Session.GetString("role");
            User = _userService.FindUser(user);
        }

        public IActionResult OnPost(string user)
        {
            User = _userService.FindUser(user);
            _userService.DeleteUser(User);
            return RedirectToPage("AllUsers");
        }
    }
}
