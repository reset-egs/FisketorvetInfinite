using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages.ShopsManagement
{
    public class EditProductModel : PageModel
    {
        public IProductService _productService;

        public EditProductModel(IProductService service)
        {
            _productService = service;
        }

        private Product _product = new Product();

        [BindProperty]
        public Product Product
        {
            get => _product;
            set => _product = value;
        }

        public string Role { get; set; }

        public void OnGet(int id)
        {
            Role = HttpContext.Session.GetString("role");
            Product = _productService.FindProduct(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _productService.UpdateProduct(Product);
                return RedirectToPage("./Store");
            }
            return Page();  
        }
    }
}
