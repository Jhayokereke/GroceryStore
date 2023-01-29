using GroceryStore.Commons.Enums;
using GroceryStore.Models;
using System;
using System.Collections.Generic;

namespace GroceryStore.Data
{
    public class DataStore
    {
        public DataStore()
        {
            VAT = 7.5;
            Products = new List<Product>
            {
                new Product("Ije garri") { Price = 300m },
                new Product("Milo") { Price = 1250m },
                new Product("Milk") { Price = 1900m },
                new Product("Indomie") { Price = 4100m },
                new Product("Sugar") { Price = 400m },
                new Product("Bread") { Price = 700m },
                new Product("Margarine") { Price = 850m },
                new Product("Tooth Paste") { Price = 300m },
                new Product("Eva soap") { Price = 270m },
                new Product("Malt") { Price = 165.99m },
                new Product("Coke") { Price = 85.99m },
                new Product("Bottle water") { Price = 50m }
            };
            Users = new List<User>
            {
                new User("Jonathan Kent", new Role[]{Role.Manager, Role.Staff})
            };
        }

        public double VAT { get; set; }
        public List<Product> Products { get; set; }
        public List<User> Users { get; set; }
    }
}
