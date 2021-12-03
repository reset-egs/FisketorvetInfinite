namespace FisketorvetInfinte.Models
{
    public class User
    {
        [Required(ErrorMessage = "The username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        
        public string ? Role { get; set; }

        public User FindUser(string username)
        {
            List<User> users = JsonFileReaderUser.ReadJson("./Data/Users.json");
            foreach(var user in users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }
            return null;
        }

        public static void AddUser(User u)
        {
            List<User> users = JsonFileReaderUser.ReadJson("./Data/Users.json");
            users.Add(u);
            JsonFileWriterUser.WriteToJson(users, @"C:\Users\szymo\Documents\Notes\Computer Science\Software Design\OLA\Fisketorvet Infinite\FisketorvetInfinite\FisketorvetInfinte\Data\Users.json");
        }
    }
}
