namespace Jazper.Website.Models;

public class Project
{
    public required string Name { get; set; }
    
    public required string Url { get; set; }

    public string? RepositoryUrl { get; set; } = null;
    
    public required string Description { get; set; }
}