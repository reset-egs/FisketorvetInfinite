﻿namespace FisketorvetInfinte.Services.UserServices
{
    public interface IUserService
    {
        User GetUser(string username);

        User FindUser(string username);

        void AddUser(User u);

        List<User> AllUsers();

        void UpdateUser(string Username, User u);

        void DeleteUser(User u);
    }
}