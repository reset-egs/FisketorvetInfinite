namespace FisketorvetInfinte.Pages.ShopsManagement
{
    public class DeleteShopModel : PageModel
    {
        public IShopService ShopService { get; set; }

        public DeleteShopModel(IShopService service)
        {
            ShopService = service;
        }

        public Shop Shop { get; set; }

        public void OnGet(int shopId)
        {
            Shop = ShopService.FindShop(shopId);
        }

        public IActionResult OnPost(int shopId)
        {
            Shop = ShopService.FindShop(shopId);
            ShopService.DeleteShop(Shop);
            return RedirectToPage("AllShops");
        }
    }
}
