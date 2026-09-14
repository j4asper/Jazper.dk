namespace Jazper.Website.Models;

public class Project
{
    public required string Name { get; set; }

    public required string Url { get; set; }

    public string? RepositoryUrl { get; set; } = null;

    public required string Description { get; set; }

    /// Short "language · category" label shown above the card title, e.g. "C# · Discord bot".
    public string? Kicker { get; set; }

    /// Phosphor icon name (without the "ph-" prefix) shown before the meta line.
    public string? MetaIcon { get; set; }

    /// First segment of the meta line, e.g. "28 stars".
    public string? MetaPrimary { get; set; }

    /// Second segment of the meta line, e.g. "Open source".
    public string? MetaSecondary { get; set; }
}