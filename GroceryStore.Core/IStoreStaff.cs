using GroceryStore.Models.DTOs;
using System;
using System.Collections.Generic;

namespace GroceryStore.Core
{
    public interface IStoreStaff
    {
        delegate decimal CalculateTotal(int quantity, decimal unitPrice);
        void RemoveFromProduct(string id, int numberChange);
        ProductDTO GetProduct(string id);
        decimal GetProductPrice(ProductDTO product, int quantity, CalculateTotal calculateTotal);
        IEnumerable<ProductDTO> GetAllProducts();
        decimal GetVATOnPurchase(decimal totalPrice);
    }
}