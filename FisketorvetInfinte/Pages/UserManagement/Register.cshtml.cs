namespace FisketorvetInfinte.Pages
{
    public class RegisterModel : PageModel
    {
       
        [BindProperty]
        public UserViewModel User { get; set; } = new UserViewModel();

        [BindProperty]
        public string? Username { get; set; }

        public string? Msg { get; set; }

        public string? Role { get; set; }

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
                        User u = new User();
                        u.Username = User.Username;
                        u.Password = User.Password;
                        u.Name = User.Name;
                        u.Address = User.Address;
                        u.PhoneNumber = User.PhoneNumber;
                        u.Email = User.Email;
                        u.Role = "user"; /*User should not be created without a role it will cause problems when logging in*/
                        UserService.AddUser(u);
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