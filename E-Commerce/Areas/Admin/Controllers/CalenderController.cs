﻿using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CalenderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
