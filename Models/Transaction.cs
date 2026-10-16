namespace midterm_app.Models;

public sealed class Transaction
{
    public int Id { get; set; }
    public int ListingId { get; set; }
    public int BuyerId { get; set; }
    public int SellerId { get; set; }
    public decimal AgreedPrice { get; set; }
    public TransactionStatus Status { get; set; } = TransactionStatus.Pending;
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? CompletedAt { get; set; }
}
