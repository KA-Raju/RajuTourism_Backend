﻿using Microsoft.AspNetCore.Mvc;

namespace BackendApi_RajuTourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
