using JazperDK.Models;
using Microsoft.AspNetCore.Mvc;

namespace JazperDK.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View(PortfolioItem.GetPortfolioItems());
        }
    }
}
