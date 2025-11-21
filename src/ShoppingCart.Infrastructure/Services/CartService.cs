using ShoppingCart.Core.Models;
using ShoppingCart.Core.Services;

namespace ShoppingCart.Infrastructure.Services
{
    public class CartService : ICartService
    {
        private readonly List<CartItem> _items = new();

        public void AddToCart(Product product)
        {
            var existing = _items.FirstOrDefault(x => x.Product.Id == product.Id);

            if (existing == null)
                _items.Add(new CartItem { Product = product, Quantity = 1 });
            else
                existing.Quantity++;
        }

        public List<CartItem> GetItems() => _items;

        public decimal GetTotal() =>
            _items.Sum(x => x.Product.Price * x.Quantity);
    }
}
