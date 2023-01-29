using GroceryStore.Data;
using GroceryStore.Models;

namespace GroceryStore.Core
{
    public class UserRepository : IUserRepository
    {
        private readonly DataStore _database;

        public UserRepository(DataStore dataStore)
        {
            _database = dataStore;
        }
        public void AddUser(User user)
        {
            _database.Users.Add(user);
        }

        public bool DeletUser(string id)
        {
            User userToDelete = GetUserById(id);
            if (userToDelete == null)
                return false;
            _database.Users.Remove(userToDelete);
            return true;
        }

        public User GetUserById(string id)
        {
            return _database.Users.Find(u => u.Id == id);
        }

        public void UpdateUser(User user)
        {
            User userToUpdate = GetUserById(user.Id);
            userToUpdate.Name = user.Name;
            userToUpdate.PasswordHash = user.PasswordHash;
            userToUpdate.Roles = user.Roles;
        }
    }
}
