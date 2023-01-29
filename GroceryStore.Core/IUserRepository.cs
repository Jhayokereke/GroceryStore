using GroceryStore.Models;
using System;

namespace GroceryStore.Core
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUserById(string Id);
        bool DeletUser(string Id);
        void UpdateUser(User user);
    }
}
