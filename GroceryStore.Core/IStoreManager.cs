using GroceryStore.Models;
using GroceryStore.Models.DTOs;
using System.Collections.Generic;

namespace GroceryStore.Core
{
    public interface IStoreManager
    {
        void AddToProduct(string id, int numberChange);
        string CreateProduct(string nameOfProduct, int quantity = 0);
        void SetVAT(double newVAT);
        void UpdateProductPrice(string id, decimal newPrice);
    }
}