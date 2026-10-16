namespace midterm_app.Models;

public sealed class ListingImage
{
    public int Id { get; set; }
    public int ListingId { get; set; }
    public string Url { get; set; } = "";
    public string AltText { get; set; } = "";
    public int DisplayOrder { get; set; }
}
