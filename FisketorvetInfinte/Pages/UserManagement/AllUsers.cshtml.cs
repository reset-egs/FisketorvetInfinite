namespace FisketorvetInfinte.Pages.UserManagement
{
    public class AllUsersModel : PageModel
    {
        public IUserService UserService { get; set; }

        [BindProperty]
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

        public IActionResult OnPostDelete()
        {
            if ( User.Username!=null)
            {
                UserService.DeleteUser(User);
                
                return RedirectToPage("AllUsers");
            }
            else return RedirectToPage("AllUsers");
        }
        
    }
}
