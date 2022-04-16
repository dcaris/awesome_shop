using AwesomeShop.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AwesomeShop.WebApp.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            ViewBag.Message = "";
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(string contactName, string emailAddress)
        {
            ViewBag.Message = "Thank you, we've received your message =)";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}