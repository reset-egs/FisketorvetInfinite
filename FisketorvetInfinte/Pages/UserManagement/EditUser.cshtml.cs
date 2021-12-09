namespace FisketorvetInfinte.Pages.UserManagement
{
    public class EditUserModel : PageModel
    {
        [BindProperty]
        public User User { get; set; } = new User();

        public string? Alert { get; set; }

        public IUserService UserService { get; set; }

        public EditUserModel(IUserService service)
        {
            UserService = service;
        }

        public void OnGet(string username)
        {
            User = UserService.FindUser(username);
        }

        public IActionResult OnPost(string Username, User u)
        {
            if (Username!=null && User.Name != null && User.Email != null && User.Role != null)
            {
                UserService.UpdateUser(Username, User);
                return RedirectToPage("./AllUsers");
            }
            else
            {
                Alert = "Please fill all required fields.";
            }
            return Page();
        }
    }
}
