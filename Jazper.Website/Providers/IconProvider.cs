namespace Jazper.Website.Providers;

public class IconProvider
{
    private readonly Dictionary<string, string> _icons;

    public IconProvider()
    {
        _icons = new Dictionary<string, string>();

        LoadIcons();
    }

    private void LoadIcons()
    {
        var svgFiles = Directory.GetFiles("wwwroot/icons", "*.svg");

        foreach (var filePath in svgFiles)
        {
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            
            var svgContent = File.ReadAllText(filePath);
            
            _icons.Add(fileNameWithoutExtension, svgContent);
        }
    }
    
    public string GetIcon(string iconName) => _icons.GetValueOrDefault(iconName) ?? throw new KeyNotFoundException();
}