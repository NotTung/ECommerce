namespace ECommerce.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public string? UserId { get; set; } // null nếu không đăng nhập
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<CartItem> Items { get; set; } = new();
    }

}