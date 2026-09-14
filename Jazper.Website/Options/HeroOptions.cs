namespace Jazper.Website.Options;

public class HeroOptions
{
    public static readonly string Hero = nameof(Hero);

    /// Short display name used in the header brand link.
    public required string Name { get; set; }

    /// Full name used in the footer copyright line.
    public required string FooterName { get; set; }

    public required string FooterLocation { get; set; }

    public required string Location { get; set; }

    public required string Heading { get; set; }

    public required string Subheading { get; set; }

    public required string PortraitSrc { get; set; }

    public required string TerminalLabel { get; set; }

    public required string TerminalWhoAmI { get; set; }

    /// Words the terminal's "$ stack --now" line types out, one after another.
    public required IReadOnlyList<string> TypedWords { get; set; }

    public required string GithubUrl { get; set; }

    public required string LinkedInUrl { get; set; }

    public required string Email { get; set; }
}
