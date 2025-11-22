using ShoppingCart.Core.Models;
using System.Collections.Generic;         // REQUIRED
using ShoppingCart.Core.Models;           // For CartItem, Product
using ShoppingCart.Core.Services;         // For ICartService

namespace ShoppingCart.Infrastructure.Services
{
    public class CartService : ICartService
    {
        private List<CartItem> _items = new List<CartItem>();

        public List<CartItem> GetItems()
        {
            return _items;
        }

        public void AddToCart(Product product)
        {
            _items.Add(new CartItem
            {
                ProductId = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = 1
            });
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
    }
}
