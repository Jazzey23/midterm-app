namespace midterm_app.Components.Features.Marketplace;

public sealed class Listing
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Category { get; set; } = "";
    public decimal Price { get; set; }
    public string Condition { get; set; } = "Good";
    public string Location { get; set; } = "";
    public string Seller { get; set; } = "Alex Reyes";
    public string Image { get; set; } = "";
    public int Days { get; set; }
    public bool Sold { get; set; }
    public string Description { get; set; } = "";
    public string Initials => string.Concat(Seller.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => n[0]));
    public Listing Copy() => (Listing)MemberwiseClone();

    public static List<Listing> Samples() => [
        New(1, "Calculus textbook", "Books", 350, "Good", "Main Library", "Mia Santos", "976dc.png", 2),
        New(2, "White laboratory coat", "Lab Essentials", 200, "Like New", "Science Building", "Jasmine Cruz", "cde37.png", 3),
        New(3, "Scientific calculator", "Electronics", 650, "Like New", "Engineering Hall", "Carlo Mendoza", "cf99f.png", 1),
        New(4, "Engineering drawing set", "Other", 280, "Good", "Student Center", "Alex Reyes", "a58cc.png", 2),
        New(5, "Everyday campus backpack", "Other", 450, "Good", "Student Center", "Bea Garcia", "7cf50.png", 3),
        New(6, "Nursing uniform · size M", "Uniforms", 400, "Like New", "Health Sciences", "Sofia Lim", "631c6.png", 1),
        New(7, "Wireless headphones", "Electronics", 850, "Good", "Main Library", "Alex Reyes", "b38f7.png", 2),
        New(8, "Introduction to Psychology", "Books", 220, "Well Used", "Liberal Arts Building", "Diego Ramos", "e26b9.png", 3),
        New(9, "Logitech wireless mouse", "Electronics", 300, "Like New", "Student Center", "Alex Reyes", "9f4ab.png", 1),
        New(10, "Organic chemistry notes & book", "Books", 180, "Good", "Science Building", "Nicole Tan", "b9fdb.png", 2),
        New(11, "Classic canvas sneakers", "Uniforms", 380, "Good", "Student Center", "Luis Torres", "d8e01.png", 3),
        New(12, "Adjustable desk lamp", "Other", 250, "Good", "Main Library", "Alex Reyes", "ce0ab.png", 1, true)
    ];
    private static Listing New(int id, string title, string category, decimal price, string condition, string location, string seller, string image, int days, bool sold = false) => new()
    {
        Id = id, Title = title, Category = category, Price = price, Condition = condition,
        Location = location, Seller = seller, Image = "images/figma/" + image, Days = days, Sold = sold,
        Description = id == 1 ? "Letting go of my calculus textbook since I no longer need it this semester. It's been well taken care of and still works great! Happy to let you check it in person before buying. Meetups on campus between classes work best for me." : "Sample listing. Ask the seller about this item's details and availability."
    };
}
