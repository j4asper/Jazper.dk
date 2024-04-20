namespace JazperDK.Models
{
    public class SocialRedirect
    {
        public string Endpoint { get; set; }
        public string RedirectUrl { get; set; }

        public SocialRedirect(string endpoint, string redirectUrl)
        {
            Endpoint = endpoint;
            RedirectUrl = redirectUrl;
        }

        public static SocialRedirect[] GetSocialRedirects()
        {
            SocialRedirect[] socialRedirects = new SocialRedirect[]
            {
                new SocialRedirect("github", "https://github.com/j4asper"),
                new SocialRedirect("gitlab", "https://gitlab.com/j4asper"),
                new SocialRedirect("snapchat", "https://www.snapchat.com/add/j4azper"),
                new SocialRedirect("linkedin", "https://www.linkedin.com/in/jasper-onsberg-christiansen"),
                new SocialRedirect("twitter", "https://twitter.com/Jazper1901"),
                new SocialRedirect("steam", "https://steamcommunity.com/id/Jasper1901"),
                new SocialRedirect("xsploit", "https://xsplo.it/")
            };

            return socialRedirects;
        }
    }
}
