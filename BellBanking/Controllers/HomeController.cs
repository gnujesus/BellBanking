﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BellBanking.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
