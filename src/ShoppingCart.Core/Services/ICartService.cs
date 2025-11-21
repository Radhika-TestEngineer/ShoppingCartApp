using ShoppingCart.Core.Models;

namespace ShoppingCart.Core.Services
{
    public interface ICartService
    {
        List<CartItem> GetItems();
        void AddToCart(Product product);
        decimal GetTotal();
    }
}
