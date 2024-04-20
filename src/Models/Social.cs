namespace JazperDK.Models
{
    public class Social
    {
        public string Platform { get; set; }

        public string Description { get; set; }

        public string ImgAlt {
            get
            {
                return $"{Platform} Icon";
            }
        }

        public string Link
        {
            get
            {
                if (Platform.ToLower() == "email")
                {
                    return "mailto:jasper@jazper.dk";
                }
                else
                {
                    return $"/{Platform}";
                }
            }
        }

        public string Img
        {
            get
            {
                if (Platform.ToLower() == "email")
                {
                    return "media/images/protonmail.svg";
                }
                if (Platform.ToLower() == "twitter")
                {
                    return "media/images/x.svg";
                }
                return $"media/images/{Platform.ToLower()}.svg";
            }
        }

        public Social(string platform, string description)
        {
            Platform = platform;
            Description = description;
        }

        public static Social[] GetSocials()
        {
            Social[] socials =
            [
                new Social("LinkedIn", "Se de erfaringer jeg har og hvad jeg laver til hverdag lige nu"),
                new Social("XSploit", "Cyber Security Capture The Flag Team Github"),
                new Social("Twitter", "Bruger sjældent Twitter, men her er et link til den"),
                new Social("Github", "Min egen Gthub, hvor man kan finde nogle af mine projekter"),
                new Social("Portfolio", "En samling af projekter jeg har lavet og bliver brugt af andre"),
                new Social("Email", "Email")
            ];

            return socials;
        }
    }
}
