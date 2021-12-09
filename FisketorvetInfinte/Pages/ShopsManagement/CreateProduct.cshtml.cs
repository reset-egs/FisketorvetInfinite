namespace FisketorvetInfinte.Pages.ShopsManagement
{
    public class CreateProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; } = new Product();

        public Image? Image { get; set; }

        public IProductService _productService;

        public CreateProductModel(IProductService service)
        {
            _productService = service;
        }

        public void OnGet()
        {
          
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