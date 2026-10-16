namespace midterm_app.Models;

public sealed class Notification
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public NotificationType Type { get; set; } = NotificationType.General;
    public string Title { get; set; } = "";
    public string Body { get; set; } = "";
    public int? ListingId { get; set; }
    public int? ConversationId { get; set; }
    public int? TransactionId { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? ReadAt { get; set; }
}
