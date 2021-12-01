using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public string username { get; set; }
        [BindProperty]
        public string password { get; set; }

        [BindProperty]
        public User User { get; set; }

        public string Msg { get; set; }

        public List<User> Users { get; set; } = JsonFileReaderUser.ReadJson("./Data/Users.json");

        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            if (User.FindUser(username) != null)
            {
                User = User.FindUser(User.Username);
            } 
            else
            {
                Msg = "Invalid";
                return Page();
            }
            
            if (User.Password == password)
            {
                HttpContext.Session.SetString("username", User.Username);
                return RedirectToPage("Index");
            }
             
            else
            {
                Msg = "Invalid";
                return Page();
            }
            return Page();
        }
    }
}
