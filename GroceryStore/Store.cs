using System.Collections.Generic;

namespace GroceryStore
{
    public interface IStore : IStoreManager, IStoreStaff
    {
        
    }
    public interface IStoreManager
    {
        List<Product> Products { get; set; }
        double VAT { get; }
        void AddToProduct(string id, int numberChange);
        string CreateProduct(string nameOfProduct, int quantity = 0);
        void SetVAT(double newVAT);
        void UpdateProductPrice(string id, decimal newPrice);
    }

    public interface IStoreStaff
    {
        void RemoveFromProduct(string id, int numberChange);
        Product GetProduct(string id);
    }

    public class Store : IStore
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public double VAT { get; private set; }

        public void UpdateProductPrice(string id, decimal newPrice)
        {
            foreach (var item in Products)
            {
                if (item.Id == id)
                    item.Price = newPrice;
            }
        }

        public void SetVAT(double newVAT)
        {
            VAT = newVAT;
        }

        public void AddToProduct(string id, int numberChange)
        {
            foreach (var item in Products)
            {
                if (item.Id == id)
                    item.Quantity += numberChange;
            }
        }

        public void RemoveFromProduct(string id, int numberChange)
        {
            foreach (var item in Products)
            {
                if (item.Id == id)
                    item.Quantity -= numberChange;
            }
        }

        public string CreateProduct(string nameOfProduct, int quantity = 0)
        {
            Product prod = new Product(nameOfProduct, quantity);
            Products.Add(prod);
            return prod.Id;
        }

        public Product GetProduct(string id)
        {
            foreach (var item in Products)
            {
                if (item.Id == id)
                    return item;
            }

            return null;
        }
    }
}