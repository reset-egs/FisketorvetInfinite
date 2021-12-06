using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages.UserManagement
{
    public class AllUsersModel : PageModel
    {
        public IUserService UserService { get; set; }
        public User User { get; set; } = new User();
        public List<User> Users { get; set; } = JsonFileUserService.ReadJson("./Data/Users.json"); 
        public AllUsersModel(IUserService service)
        {
            UserService = service;
        }
        public void OnGet(string User)
        {
            Users = UserService.AllUsers();  
        }
 
        public IActionResult OnPostDelete(User User)
        {
            Users.Remove(User);
            JsonFileUserService.WriteToJson(Users, "../Users.json");
            return RedirectToPage("AllUsers");
        }
    }
}
