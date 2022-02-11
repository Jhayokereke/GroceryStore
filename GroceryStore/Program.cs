using System;
using System.Collections.Generic;
using System.Threading;

namespace GroceryStore
{
    public class Program
    {
        public static List<Product> Products;
        static void Main()
        {
            Thread.Sleep(3000);
            foreach (var prod in Products)
            {
                Console.WriteLine(prod.Id + "\n");
            }
        }
        public static List<Product> CreateProducts()
        {
            var listOfProducts = new List<Product>()
            {
                new Product("Ije garri") { Price = 300m },
                new Product("Milo") { Price = 1250m },
                new Product("Milk") { Price = 1900m },
                new Product("Indomie") { Price = 4100m },
                new Product("Sugar") { Price = 400m },
                new Product("Bread") { Price = 700m }
            };

            Products = listOfProducts;

            return listOfProducts;
        }
    }
}