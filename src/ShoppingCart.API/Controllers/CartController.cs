using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Core.Models;
using ShoppingCart.Core.Services;

namespace ShoppingCart.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cart;

        public CartController(ICartService cart)
        {
            _cart = cart;
        }

        [HttpPost("add")]
        public IActionResult Add(Product p)
        {
            _cart.AddToCart(p);
            return Ok(new { message = "Added" });
        }

        [HttpGet]
        public IActionResult GetCart() => Ok(_cart.GetItems());

        [HttpGet("total")]
        public IActionResult GetTotal() => Ok(new { total = _cart.GetTotal() });
    }
}
