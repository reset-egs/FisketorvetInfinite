namespace FisketorvetInfinte.Models
{
    public class User
    {
        [Required, MaxLength(100)]
        public string Username { get; set; }

        [Required, MaxLength(100)]
        public string Password { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool IsAdministrator { get; set; }

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
    }
}
