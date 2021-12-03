using FisketorvetInfinte.Services.StoreServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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

        public void OnGet()
        {
            Products = JsonFileProductService.ReadJson("./Data/Products.json");
        }
    }
}
