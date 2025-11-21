using Microsoft.AspNetCore.Mvc.RazorPages;
using ShoppingCart.Core.Models;
using ShoppingCart.Web.Services;

public class IndexModel : PageModel
{
    private readonly ApiClient _api;

    public List<Product> Products { get; set; } = new();

    public IndexModel(ApiClient api)
    {
        _api = api;
    }

    public async Task OnGet()
    {
        Products = await _api.GetProducts();
    }
}
