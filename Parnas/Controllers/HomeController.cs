using Microsoft.AspNetCore.Mvc;
using Parnas.Models;
using System.Diagnostics;

namespace ParnasFront.Controllers
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

        public IActionResult Custom()
        {
            return View();
        }
        public IActionResult CaseGallery()
        {
            return View();
        }
        public IActionResult SystemGallery()
        {
            return View();
        }
        public IActionResult ModKit()
        {
            return View();
        }
        public IActionResult ExtremeCooling()
        {
            return View();
        }
        public IActionResult Ourservices()
        {
            return View();
        }
        public IActionResult Warranty()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
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