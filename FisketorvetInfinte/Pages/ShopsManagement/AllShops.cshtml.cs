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

        

        public void OnGet()
        {
            Shops = JsonFileShopService.ReadJson("./Data/Shop.json");

        }
    }
}
