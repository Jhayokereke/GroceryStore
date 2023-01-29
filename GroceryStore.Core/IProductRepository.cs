using GroceryStore.Models;
using GroceryStore.Models.DTOs;
using System.Collections.Generic;

namespace GroceryStore.Core
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        ProductDTO GetProductById(string Id);
        bool DeleteProduct(string id);
        void UpdateProduct(ProductDTO product);
        IReadOnlyCollection<ProductDTO> GetProducts();
    }
}
