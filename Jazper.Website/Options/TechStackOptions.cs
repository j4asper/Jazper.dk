using System.ComponentModel.DataAnnotations;
using Jazper.Website.Models;

namespace Jazper.Website.Options;

public class TechStackOptions
{
    public static readonly string Stack = nameof(Stack);
    
    [Required]
    public required IReadOnlyList<TechStackCategory> Categories { get; set; }
}