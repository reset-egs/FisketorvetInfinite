namespace FisketorvetInfinte.Pages
{
    public class WelcomeModel : PageModel
    {
        public string? Role { get; set; }
   
        public List<User>? Users { get; set; } = new List<User>();

        [BindProperty]
        public User? User { get; set; }
        
        public void OnGet()
        {
            Role = HttpContext.Session.GetString("role");
        }
    }
}
