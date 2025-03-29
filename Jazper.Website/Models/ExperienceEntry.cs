namespace Jazper.Website.Models;

public class ExperienceEntry
{
    public required string Name { get; set; }
    
    public required string Description { get; set; }
    
    public required string Link { get; set; }
    
    public required string Logo { get; set; }
    
    public required string From { get; set; }
    
    public required string To { get; set; }
    
    public required EmploymentStatus EmploymentStatus { get; set; }
    
    public required WorkLocation WorkLocation { get; set; }
}