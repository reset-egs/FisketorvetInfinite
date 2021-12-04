namespace FisketorvetInfinte.Services.UserServices
{
    public class UserService : IUserService
    {
        public List<User> GetUsers { get; }
        List<User> users = JsonFileUserService.ReadJson("./Data/Users.json");

        public List<User> AllUsers()
        {
            return users;
        }
        public User FindUser(string username)
        {
            
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
           
            users.Add(u);
            JsonFileUserService.WriteToJson(users, "./Data/Users.json");
        }
    }
}
