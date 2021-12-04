using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages.ShopsManagement
{
    public class CreateProductModel : PageModel
    {
        public string Role { get; set; }

        public Product Product { get; set; }

        public Image Image { get; set; }


        public void OnGet()
        {
            Role = HttpContext.Session.GetString("role");
        }
    }
}
