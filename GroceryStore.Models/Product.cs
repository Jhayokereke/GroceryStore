using GroceryStore.Commons.Utilities;

namespace GroceryStore.Models
{
    public class Product
    {
        public Product(string productName, int quantity = 0)
        {
            Id = Generator.GenerateId();
            Name = productName;
            Quantity = quantity;
        }
        public string Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsDiscounting { get; set; }
        public double Discount { get; set; }
    }
}
