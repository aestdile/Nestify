//==================================================
// Welcome! I'm Mukhtor C#.Net Junior Developer
// Residental Training Software
//==================================================


using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RESTFulSense.Controllers;

namespace Nestify.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HomeController : RESTFulController
    {
        private readonly ILogger<HomeController> logger; // Logging -> ma'lumotlarni ekranga chiqarish  

        public HomeController(ILogger<HomeController> logger) =>
            this.logger = logger;


        [HttpGet]
        public ActionResult<string> Get()
        {
            logger.LogTrace("I'm logging trace"); // fayllar qanday joylashganligi va nima ishlar olib borilayotganligi
            logger.LogDebug("I'm logging debug"); // debug qiladi
            logger.LogInformation("I'm logging info"); // ma'lumotlarni chiqarish
            logger.LogWarning("I'm logging warming"); // dasturda qandaydir limitni oshib ketishligi haqida xabar beradi
            logger.LogError("I'm logging error"); // xatoliklarni ko'rsatadi
            logger.LogCritical("I'm logging critical");


            return Ok("Residental Training Software!");
        }
    }
}

