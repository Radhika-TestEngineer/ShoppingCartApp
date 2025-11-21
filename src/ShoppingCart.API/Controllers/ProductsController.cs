using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Core.Models;

namespace ShoppingCart.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var list = new List<Product>
            {
                new Product { Id = 1, Name="Laptop", Price=80000 },
                new Product { Id = 2, Name="Keyboard", Price=1500 },
                new Product { Id = 3, Name="Mouse", Price=800 }
            };

            return Ok(list);
        }
    }
}
