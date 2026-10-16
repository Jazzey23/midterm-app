using System.ComponentModel.DataAnnotations;

namespace midterm_app.Models;

public sealed class Review
{
    public int Id { get; set; }
    public int TransactionId { get; set; }
    public int ReviewerId { get; set; }
    public int ReviewedUserId { get; set; }
    [Range(1, 5)]
    public int Rating { get; set; }
    public string Comment { get; set; } = "";
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}
