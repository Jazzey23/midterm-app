namespace midterm_app.Models;

public sealed class Conversation
{
    public int Id { get; set; }
    public int ListingId { get; set; }
    public int BuyerId { get; set; }
    public int SellerId { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}
