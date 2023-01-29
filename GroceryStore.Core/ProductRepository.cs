using GroceryStore.Data;
using GroceryStore.Models;
using GroceryStore.Models.DTOs;
using System.Collections.Generic;

namespace GroceryStore.Core
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataStore _database;

        public ProductRepository(DataStore dataStore)
        {
            _database = dataStore;
        }
        public void AddProduct(Product product)
        {
            _database.Products.Add(product);
        }

        public bool DeleteProduct(string id)
        {
            Product productToDelete = _database.Products.Find(p => p.Id == id);
            if (productToDelete == null)
                return false;
            _database.Products.Remove(productToDelete);
            return true;
        }

        public ProductDTO GetProductById(string id)
        {
            return _database.Products.Find(p => p.Id == id)?.MapToDTO();
        }

        public IReadOnlyCollection<ProductDTO> GetProducts()
        { 
            var products = _database.Products;
            List<ProductDTO> productDTOs = new List<ProductDTO>();
            foreach (var product in products)
            {
                productDTOs.Add(product.MapToDTO());
            }
            return productDTOs;
        }

        public void UpdateProduct(ProductDTO product)
        {
            Product productToUpdate = _database.Products.Find(p => p.Id == product.Id);
            if (productToUpdate != null)
                productToUpdate.MapFromDTO(product);
        }

    }
}
