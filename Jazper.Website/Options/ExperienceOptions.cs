using Jazper.Website.Models;

namespace Jazper.Website.Options;

public class ExperienceOptions
{
    public static readonly string Experience = nameof(Experience);
    
    public required List<ExperienceEntry> ExperienceList { get; set; }
}