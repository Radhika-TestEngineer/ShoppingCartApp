using ShoppingCart.Core.Models;
using ShoppingCart.Infrastructure.Services;

namespace ShoppingCart.Tests
{
    public class CartServiceTests
    {
        [Fact]
        public void AddToCart_AddsItem()
        {
            var service = new CartService();

            var product = new Product { Id = 1, Name = "Laptop", Price = 60000 };

            service.AddToCart(product);

            var items = service.GetItems();

            Assert.Single(items);
        }

        [Fact]
        public void GetTotal_WorksCorrectly()
        {
            var service = new CartService();

            service.AddToCart(new Product { Id = 1, Name = "Laptop", Price = 60000 });
            service.AddToCart(new Product { Id = 1, Name = "Laptop", Price = 60000 });

            Assert.Equal(120000, service.GetTotal());
        }
    }
}
