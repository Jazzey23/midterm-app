namespace midterm_app.Models;

public sealed class Report
{
    public int Id { get; set; }
    public int ReporterId { get; set; }
    public int? ListingId { get; set; }
    public int? ReportedUserId { get; set; }
    public string Reason { get; set; } = "";
    public string Details { get; set; } = "";
    public ReportStatus Status { get; set; } = ReportStatus.Pending;
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? ResolvedAt { get; set; }
}
