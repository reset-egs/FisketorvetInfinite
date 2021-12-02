namespace FisketorvetInfinte.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public string Role { get; set; }

        public void OnGet()
        {
            Role = HttpContext.Session.GetString("role");
        }
    }
}