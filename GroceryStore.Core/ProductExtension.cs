using GroceryStore.Models;
using GroceryStore.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Core
{
    public static class ProductExtension
    {
        public static ProductDTO MapToDTO(this Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                IsDiscounting = product.IsDiscounting,
                Discount = product.Discount
            };
        }

        public static Product MapFromDTO(this Product product, ProductDTO productDTO)
        {
            product.Name = productDTO.Name;
            product.Price = productDTO.Price;
            product.Quantity = productDTO.Quantity;
            product.IsDiscounting = productDTO.IsDiscounting;
            product.Discount = productDTO.Discount;

            return product;
        }
    }
}
