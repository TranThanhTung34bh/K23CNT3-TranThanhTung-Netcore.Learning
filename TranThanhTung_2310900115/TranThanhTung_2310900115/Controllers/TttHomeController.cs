﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TranThanhTung_2310900115.Models;

namespace TranThanhTung_2310900115.Controllers
{
    public class TttHomeController : Controller
    {
        private readonly ILogger<TttHomeController> _logger;

        public TttHomeController(ILogger<TttHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TttIndex()
        {
            return View();
        }


        public IActionResult TttAbout()
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
