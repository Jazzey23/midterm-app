namespace midterm_app.Models;

public sealed class Favorite
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ListingId { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}
