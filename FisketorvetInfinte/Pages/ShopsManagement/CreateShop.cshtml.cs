using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace FisketorvetInfinte.Pages
{
    public class CreateShopModel : PageModel
    {

        [BindProperty]
        public Shop? Shop { get; set; } = new Shop();

        public IShopService ShopService { get; set; }

        public CreateShopModel(IShopService service)
        {
            ShopService = service;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(Shop shop)
        {
            if (ModelState.IsValid)
            {
                ShopService.AddShop(Shop);
                return RedirectToPage("./AllShops");
            }
            return Page();
        }
    }
}
