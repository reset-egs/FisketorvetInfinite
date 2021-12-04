namespace FisketorvetInfinte.Services.UserServices
{
    public interface IUserService
    {
        User FindUser(string username);

        void AddUser(User u);

        List<User> AllUsers();
    }
}
