using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetInfinte.Pages.UserManagement
{
    public class EditUserModel : PageModel
    {
        [BindProperty]
        public User User { get; set; } = new User();

        public IUserService UserService { get; set; }

        public EditUserModel(IUserService service)
        {
            UserService = service;
        }

        public void OnGet(string username)
        {
            User = UserService.GetUser(username);
        }

        public IActionResult OnPost()
        {
            if ((ModelState.GetFieldValidationState("Name") == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Valid)&&
               (ModelState.GetFieldValidationState("Email") == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Valid))
            {
                UserService.UpdateUser(User);
                return RedirectToPage("./AllUsers");
            }
            return Page();
        }
    }
}
