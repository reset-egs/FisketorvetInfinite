namespace FisketorvetInfinte.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }

        public string Role { get; set; }

        public IUserService UserService { get; set; }

        public Index1Model(IUserService service)
        {
            UserService = service;
        }   

        public void OnGet()
        {
            Role = HttpContext.Session.GetString("role");
        }

        public IActionResult OnPost()
        {
            if (UserService.FindUser(Username) != null)
            {
                User = UserService.FindUser(User.Username);
            }
            else
            {
                Msg = "User does not exists. Register to make a new account.";
                return Page();
            }

            if (User.Password == Password)
            {
                HttpContext.Session.SetString("role", User.Role);
                return RedirectToPage("../Welcome");
            }

            else
            {
                Msg = "Password is incorrect, please try again.";
                return Page();
            }
        }
    }
}
