namespace FisketorvetInfinte.Pages
{
    public class AllShopsModel : PageModel
    {

        public IShopService _shopService;

        public AllShopsModel(IShopService service)
        {
            _shopService = service;
        }

        public List<Shop> Shops { get; set; }

        

        public void OnGet()
        {
            Shops = JsonFileShopService.ReadJson("./Data/Shop.json");

        }
    }
}
