using Jazper.Website.Models;

namespace Jazper.Website.Options;

public class SecurityOptions
{
    public static readonly string Security = nameof(Security);

    public required string Intro { get; set; }

    public required string HighlightBadge { get; set; }

    public required string HighlightBody { get; set; }

    public required IReadOnlyList<SecurityProfile> Profiles { get; set; }
}
