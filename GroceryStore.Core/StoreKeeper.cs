using GroceryStore.Data;
using GroceryStore.Models;
using GroceryStore.Models.DTOs;
using System;
using System.Collections.Generic;

namespace GroceryStore.Core
{
    public class StoreKeeper : IStoreKeeper
    {
        private readonly DataStore _database;
        private readonly IProductRepository _productRepo;

        public StoreKeeper(DataStore dataStore, IProductRepository productRepository)
        {
            _database = dataStore;
            _productRepo = productRepository;
        }

        public void UpdateProductPrice(string id, decimal newPrice)
        {
            foreach (var item in _database.Products)
            {
                if (item.Id == id)
                    item.Price = newPrice;
            }
        }

        public void SetVAT(double newVAT)
        {
            _database.VAT = newVAT;
        }

        public void AddToProduct(string id, int numberChange)
        {
            foreach (var item in _database.Products)
            {
                if (item.Id == id)
                    item.Quantity += numberChange;
            }
        }

        public void RemoveFromProduct(string id, int numberChange)
        {
            foreach (var item in _database.Products)
            {
                if (item.Id == id)
                    item.Quantity -= numberChange;
            }
        }

        public string CreateProduct(string nameOfProduct, int quantity = 0)
        {
            Product prod = new Product(nameOfProduct, quantity);
            _productRepo.AddProduct(prod);
            return prod.Id;
        }

        public ProductDTO GetProduct(string id)
        {
            return _productRepo.GetProductById(id);
        }

        public decimal GetProductPrice(ProductDTO product, int quantity, IStoreStaff.CalculateTotal calculateTotal)
        {
            return calculateTotal(quantity, product.Price);
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            return _productRepo.GetProducts();
        }

        public decimal GetVATOnPurchase(decimal totalPrice)
        {
            return totalPrice * (decimal)_database.VAT / 100;
        }
    }
}