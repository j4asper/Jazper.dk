using Jazper.Website.Models;

namespace Jazper.Website.Options;

public class FlagshipOptions
{
    public static readonly string Flagship = nameof(Flagship);

    /// Small uppercase badge above the title, e.g. "flagship :: live since 2020".
    public required string Badge { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    public required string PrimaryLinkUrl { get; set; }

    public required string PrimaryLinkLabel { get; set; }

    public required IReadOnlyList<string> Tags { get; set; }

    public required IReadOnlyList<FlagshipFact> Facts { get; set; }
}
