using JazperDK.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JazperDK.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Add easter egg cookie
            if (Request.Cookies.Keys.Contains("IsAdmin"))
            {
                if (Request.Cookies["IsAdmin"] == "true")
                {
                    return Redirect("/media/videos/hackerman.mp4");
                }
            }
            else
            {
                Response.Cookies.Append("IsAdmin", "false");
            }

            // Add onion url header, IP and Geolocation
            if (!Request.Headers.Host.ToString().EndsWith(".onion"))
            {
                // Don't add Onion-Location header if ONION_URL env var isn't set.
                if (Environment.GetEnvironmentVariable("ONION_URL") != null) {
                    Response.Headers.Append("Onion-Location", Environment.GetEnvironmentVariable("ONION_URL") + Request.Path.ToString());
                }

                ViewData["HasIP"] = true;

                // CF-Connecting-IP is a header sent by cloudflare that contains the remote users IP adress when using cloudflares proxy.
                if (Request.Headers["CF-Connecting-IP"].ToString() == String.Empty)
                {
                    ViewData["IP"] = "i.dont.know.ip";
                    ViewData["Location"] = "Ukendt";
                }
                else
                {
                    ViewData["IP"] = Request.Headers["CF-Connecting-IP"].ToString();
                    ViewData["Location"] = Request.Headers["CF-IPCountry"].ToString();
                }
            }
            else
            {
                ViewData["HasIP"] = false;
            }

            return View(Social.GetSocials());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}