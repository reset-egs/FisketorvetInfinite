namespace FisketorvetInfinte.Pages.Shops
{
    public class StoreModel : PageModel
    {
        public IProductService _productService;

        public StoreModel(IProductService service)
        {
            _productService = service;
        }

        public List<Product> Products { get; set; }

        public Product Product { get; set; } = new Product();

        public string Role { get; set; }

        public void OnGet()
        {
            Products = JsonFileProductService.ReadJson("./Data/Products.json");
            Role = HttpContext.Session.GetString("role");
        }
    }
}
