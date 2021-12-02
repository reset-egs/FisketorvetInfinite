namespace FisketorvetInfinte.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
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