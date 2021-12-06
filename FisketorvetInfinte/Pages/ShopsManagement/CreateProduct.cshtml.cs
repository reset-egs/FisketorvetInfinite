using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static FisketorvetInfinte.Models.Product;

namespace FisketorvetInfinte.Pages.ShopsManagement
{
    public class CreateProductModel : PageModel
    {
        public string Role { get; set; }

        [BindProperty]
        public Product Product { get; set; } = new Product();
    
        public Image Image { get; set; }

        public IProductService _productService;

        public CreateProductModel(IProductService service)
        {
            _productService = service;
        }


        public void OnGet()
        {
            Role = HttpContext.Session.GetString("role");
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(Product);
                return RedirectToPage("./Store");
            }
            return Page();
        }
    }
}
