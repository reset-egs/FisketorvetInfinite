namespace FisketorvetInfinte.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public User User { get; set; }

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
                Msg = "Username or password is not correct.";
                return Page();
            }

            if (User.Password == Password)
            {
                HttpContext.Session.SetString("role", User.Role);
                return RedirectToPage("../Welcome");
            }

            else
            {
                Msg = "Invalid";
                return Page();
            }
        }
    }
}
