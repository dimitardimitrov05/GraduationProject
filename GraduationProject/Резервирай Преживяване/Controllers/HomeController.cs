﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Резервирай_Преживяване.Models;

namespace Резервирай_Преживяване.Controllers
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
            return View();
        }

        [HttpGet]
        public IActionResult Sofia()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Sozopol()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Bansko()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}