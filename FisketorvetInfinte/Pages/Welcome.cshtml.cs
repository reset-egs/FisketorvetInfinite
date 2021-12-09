namespace FisketorvetInfinte.Pages
{
    public class WelcomeModel : PageModel
    {
        public string? Role { get; set; }
        
        public void OnGet()
        {
            Role = HttpContext.Session.GetString("role");
        }
    }
}
