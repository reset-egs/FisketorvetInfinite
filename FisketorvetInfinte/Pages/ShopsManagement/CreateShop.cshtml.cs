using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages
{
    public class CreateShopModel : PageModel
    {

        public Shop Shop { get; set; }

        public IShopService ShopService { get; set; }

        public CreateShopModel(IShopService service)
        {
            ShopService = service;
        }

        public void OnGet()
        {
        }
    }
}
