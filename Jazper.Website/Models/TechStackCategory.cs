namespace Jazper.Website.Models;

public class TechStackCategory
{
    public required string Title { get; set; }
    
    public required IReadOnlyList<TechStackEntry> Entries { get; set; }
}