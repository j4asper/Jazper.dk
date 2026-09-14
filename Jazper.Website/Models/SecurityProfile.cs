namespace Jazper.Website.Models;

public class SecurityProfile
{
    /// Phosphor icon name (without the "ph-" prefix).
    public required string Icon { get; set; }

    public required string Label { get; set; }

    public required string Href { get; set; }

    public string? SubLabel { get; set; }
}
