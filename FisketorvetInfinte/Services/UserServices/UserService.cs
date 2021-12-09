namespace FisketorvetInfinte.Services.UserServices
{
    public class UserService : IUserService
    {
        List<User> users = JsonFileUserService.ReadJson("./Data/Users.json");

        public User GetUser(string Username)
        {
            foreach (var User in users)
            {
                if (User.Username == Username)
                {
                    return User;
                }
            }
            return null;
        }

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

        public void UpdateUser(string Username, User u)
        {
            {
                if (u != null)

                    foreach (var user in users)
                    {
                        if (Username == user.Username)
                        {
                            user.Name = u.Name;
                            user.Address = u.Address;
                            user.PhoneNumber = u.PhoneNumber;
                            user.Email = u.Email;
                            user.Role = u.Role;
                        }
                    }
                JsonFileUserService.WriteToJson(users, "./Data/Users.json");
            }
        }

        public void DeleteUser(User u)
        {
            if (u != null)
            {
                foreach (var user in users)
                {
                    if (u.Username == user.Username)
                    {
                        users.Remove(u);
                        break;
                    }
                }
            }
            JsonFileUserService.WriteToJson(users, "./Data/Users.json");
        }
    }
}