using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages.ShopsManagement
{
    public class ShopInfoModel : PageModel
    {
        public IShopService shopService;

        public ShopInfoModel(IShopService service)
        {
            shopService = service;
        }
        public Shop Shop { get; set; }
        public void OnGet(int ShopId)
        {
            Shop = shopService.FindShop(ShopId);
        }
    }
}
