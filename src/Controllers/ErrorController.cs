using Microsoft.AspNetCore.Mvc;

namespace JazperDK.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewData["StatusCode"] = statusCode.ToString();
                    ViewData["Message"] = "Not Found";
                    break;
            }
            return View();
        }
    }
}
