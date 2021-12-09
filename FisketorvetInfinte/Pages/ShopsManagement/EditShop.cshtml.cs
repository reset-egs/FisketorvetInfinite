namespace FisketorvetInfinte.Pages.ShopsManagement
{
    public class EditShopModel : PageModel
    {
        public IShopService shopService;

        public EditShopModel(IShopService service)
        {
            shopService = service;
        }

        public Shop shop = new Shop();

        [BindProperty]
        public Shop Shop
        {
            get => shop;
            set => shop = value;
        }

        public void OnGet(int ShopId)
        {
            Shop = shopService.FindShop(ShopId);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                shopService.UpdateShop(Shop);
                return RedirectToPage("./AllShops");
            }
            return Page();
        }
    }
}
