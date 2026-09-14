namespace Jazper.Website.Models;

public class Certification
{
    /// Phosphor icon name (without the "ph-" prefix).
    public required string Icon { get; set; }

    public required string Kicker { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public required CertificationStatus Status { get; set; }

    public required string Href { get; set; }
}
