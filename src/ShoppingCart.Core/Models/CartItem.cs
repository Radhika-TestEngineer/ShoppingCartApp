namespace ShoppingCart.Core.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }     // required
        public string Name { get; set; }       // required
        public decimal Price { get; set; }     // required
        public int Quantity { get; set; }      // required
    }
}
