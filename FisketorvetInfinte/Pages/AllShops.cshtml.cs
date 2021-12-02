using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages
{
    public class ShopsModel : PageModel
    {

        public List<Shop> Shops { get; set; }

        public string Role { get; set; }

        public void OnGet()
        {
            Shops = JsonFileReaderShop.ReadJson("./Data/Shop.json");
            Role = HttpContext.Session.GetString("role");
        }
    }
}
