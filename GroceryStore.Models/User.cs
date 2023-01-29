using GroceryStore.Commons.Enums;
using GroceryStore.Commons.Utilities;

namespace GroceryStore.Models
{
    public class User
    {
        public User(string name, Role[] roles)
        {
            Id = Generator.GenerateId(6, "GCS");
            Roles = roles;
            Name = name;
        }
        public string Id { get; }
        public string Name { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string UserName { get; set; }
        public Role[] Roles { get; set; }
    }
}
