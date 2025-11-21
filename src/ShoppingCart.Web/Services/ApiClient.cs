using ShoppingCart.Core.Models;
using System.Net.Http.Json;

namespace ShoppingCart.Web.Services
{
    public class ApiClient
    {
        private readonly IHttpClientFactory _factory;

        public ApiClient(IHttpClientFactory factory)
        {
            _factory = factory;
        }

        public async Task<List<Product>> GetProducts()
        {
            var client = _factory.CreateClient("api");
            return await client.GetFromJsonAsync<List<Product>>("api/products") ?? new List<Product>();
        }
    }
}
