namespace FisketorvetInfinte.Pages.UserManagement
{
    public class DeleteUserModel : PageModel
    {
        public IUserService _userService { get; set; }

        public DeleteUserModel(IUserService service)
        {
            _userService = service;
        }

        [BindProperty]
        public User? User { get; set; }
        public void OnGet(string username)
        {
            User = _userService.FindUser(username);
        }

        public IActionResult OnPost(string username)
        {
            User = _userService.FindUser(username);
            _userService.DeleteUser(User);
            return RedirectToPage("AllUsers");
        }
    }
}
