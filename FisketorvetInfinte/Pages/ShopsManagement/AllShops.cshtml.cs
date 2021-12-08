namespace FisketorvetInfinte.Pages
{
    public class AllShopsModel : PageModel
    {

        public IShopService _shopService;

        public AllShopsModel(IShopService service)
        {
            _shopService = service;
        }
        [BindProperty]
        public int I { get; set; }
        public List<Shop> Shops { get; set; }
       
        public Shop Shop { get; set; }
        

        public void OnGet()
        {
            Shops = JsonFileShopService.ReadJson("./Data/Shop.json");

        }
    }
}
