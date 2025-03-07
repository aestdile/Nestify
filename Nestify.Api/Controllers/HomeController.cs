﻿//===================================
// Welcome Aestdile Startup Company
// Residental Training Software
//===================================


using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Nestify.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Residental Training Software!");

    }
}

