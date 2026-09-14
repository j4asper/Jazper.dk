using Jazper.Website.Models;

namespace Jazper.Website.Options;

public class CertificationsOptions
{
    public static readonly string Certifications = nameof(Certifications);
    
    public required string CredlyProfileUrl { get; set; }

    public required string Intro { get; set; }

    public required IReadOnlyList<Certification> CertificationList { get; set; }
}
