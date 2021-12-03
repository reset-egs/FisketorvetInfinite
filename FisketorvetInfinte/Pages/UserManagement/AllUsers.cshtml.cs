using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages.UserManagement
{
    public class AllUsersModel : PageModel
    {
<<<<<<< Updated upstream
        public IUserService UserService { get; set; }
        public AllUsersModel(IUserService service)
        {
            UserService = service;
        }
=======
        public List<User> Users { get;} = new List<User>();
>>>>>>> Stashed changes
        public void OnGet()
        {
        }
    }
}
