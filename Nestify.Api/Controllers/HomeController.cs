using Microsoft.AspNetCore.Mvc;

namespace Nestify.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
