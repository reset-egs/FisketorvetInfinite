namespace FisketorvetInfinte.Services.UserServices
{
    public class UserService : IUserService
    {
        public List<User> GetUsers { get; }
        
        public User FindUser(string username)
        {
            List<User> users = JsonFileUserService.ReadJson("./Data/Users.json");
            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }
            return null;
        }

        public void AddUser(User u)
        {
            List<User> users = JsonFileUserService.ReadJson("./Data/Users.json");
            users.Add(u);
            JsonFileUserService.WriteToJson(users, "./Data/Users.json");
        }
    }
}
