using AwesomeShop.AzureQueueLibrary.Messages;
using AwesomeShop.AzureQueueLibrary.QueueConnection;
using AwesomeShop.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AwesomeShop.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IQueueCommunicator _queueCommunicator;

        public HomeController(ILogger<HomeController> logger, IQueueCommunicator queueCommunicator)
        {
            _logger = logger;
            this._queueCommunicator = queueCommunicator;
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
        public async Task<IActionResult> ContactUs(string contactName, string emailAddress)
        {
            var tyEmail = new SendEmailCommand()
            {
                To = emailAddress,
                Subject = "Thank you for reaching out",
                Body = "We will contact you shortly"
            };
            await _queueCommunicator.SendAsync(tyEmail);

            var adminEmail = new SendEmailCommand()
            {
                To = "admin@text.com",
                Subject = "New Contact",
                Body = $"{contactName} has been reached via our contact form. Please respond back at {emailAddress}"
            };
            await _queueCommunicator.SendAsync(adminEmail);

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