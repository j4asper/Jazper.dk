namespace Jazper.Website.Options;

public class ThemeOptions
{
    public static readonly string Theme = nameof(Theme);

    /// Any valid CSS color; drives the whole accent ramp via color-mix().
    public required string AccentColor { get; set; }

    public required bool ShowSecuritySection { get; set; }
}
