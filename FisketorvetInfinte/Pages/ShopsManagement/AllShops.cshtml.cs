namespace FisketorvetInfinte.Pages
{
    public class AllShopsModel : PageModel
    {
        public IShopService _shopService;

        public AllShopsModel(IShopService service)
        {
            _shopService = service;
        }
        public string? Role { get; set; }
        public List<Shop>? Shops { get; set; }

        public Shop? Shop { get; set; }

        public void OnGet()
        {
            Role = HttpContext.Session.GetString("role");
            Shops = JsonFileShopService.ReadJson("./Data/Shop.json");
        }
    }
}