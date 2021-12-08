namespace FisketorvetInfinte.Pages.ShopsManagement
{
    public class DeleteProductModel : PageModel
    {

        public IProductService _productService;

        public Product Product = new Product();

        public string? Role { get; set; }

        public DeleteProductModel(IProductService service)
        {
            _productService = service;
        }

        public void OnGet(int id)
        {
            Role = HttpContext.Session.GetString("role");
            Product = _productService.FindProduct(id);
        }

        public IActionResult OnPost(int id)
        {
            Product = _productService.FindProduct(id);
            _productService.DeleteProduct(Product);
            return RedirectToPage("./Store");
        }
    }
}