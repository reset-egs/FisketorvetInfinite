using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages.UserManagement
{
    public class AllUsersModel : PageModel
    {
        public IUserService UserService { get; set; }
        public List<User> Users { get; set; } = new List<User>();    
        public AllUsersModel(IUserService service)
        {
            UserService = service;
        }
        public void OnGet()
        {
            Users = UserService.AllUsers();  
        }
    }
}
