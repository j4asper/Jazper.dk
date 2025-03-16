using Jazper.Website.Models;

namespace Jazper.Website.Options;

public class ProjectsOptions
{
    public static readonly string Projects = nameof(Projects);
    
    public required List<Project> ProjectList { get; set; }
}