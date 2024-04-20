namespace JazperDK.Models
{
    public class PortfolioItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Icon { get { return $"media/images/{Name.ToLower().Replace(" ", "")}.png"; } }

        public PortfolioItem(string name, string description, string url)
        {
            Name = name;
            Description = description;
            Url = url;
        }

        public static PortfolioItem[] GetPortfolioItems()
        {
            PortfolioItem[] portfolioItems =
            [
                new PortfolioItem("Guildy", "Danmarks største discord chat bot, skrevet i Python.", "https://guildy.dk"),
                new PortfolioItem("Bump Buddy", "En discord bot der sender reminders, den er på over 20.000 discord servere.", "https://bumpbuddy.xyz"),
                new PortfolioItem("Korterelink", "En hjemmeside der gør links kortere til deling.", "https://korterelink.dk"),
                new PortfolioItem("dmr.py", "En python package der webscraper motorregisteret og gør dataen let tilgængelig.", "https://pypi.org/project/dmr.py"),
                new PortfolioItem("Jazper.dk", "Denne lille hjemmeside lavet i C# med ASP.NET.", "https://github.com/j4asper/Jazper.dk")
            ];

            return portfolioItems;
        }
    }
}
