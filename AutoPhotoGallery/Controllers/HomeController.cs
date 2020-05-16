using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoPhotoGallery.Models;
using Microsoft.AspNetCore.Hosting;
using AutoPhotoGallery.Services;

namespace AutoPhotoGallery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PhotoService _photoService;

        public HomeController(ILogger<HomeController> logger, PhotoService photoService)
        {
            _logger = logger;
            _photoService = photoService;
        }

        public IActionResult Index()
        {
            return View(_photoService.GenerateList());
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
