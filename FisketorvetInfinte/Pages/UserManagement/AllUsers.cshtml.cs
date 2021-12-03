using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages.UserManagement
{
    public class AllUsersModel : PageModel
    {
        public IUserService UserService { get; set; }
        public AllUsersModel(IUserService service)
        {
            UserService = service;
        }
        public void OnGet()
        {
        }
    }
}
