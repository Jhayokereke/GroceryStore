using System;

namespace GroceryStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Ije garri") { Price = 3000m };
            var id = product.Id;

            var store = new Store();
            store.Products.Add(product);

            CheckOut ch = new SeasonCheckOut(store, "Merry Christmas");

            var newPrice = ch.CalculateDiscount(id, 0.05);


            Console.WriteLine("ChristmasCheckout discount: {0}", newPrice);
            ////////////////////////////////
            Product prod = new Product("Ije garri") { Price = 3000m };
            var i = prod.Id;

            var str = new Store();
            str.Products.Add(prod);

            var c = new CheckOut(str);

            var nP = c.CalculateDiscount(i, 0.05);

            Console.WriteLine("Checkout discount: {0}", nP);
        }
    }
}