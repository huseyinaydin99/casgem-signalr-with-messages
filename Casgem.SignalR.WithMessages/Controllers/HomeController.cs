using Casgem.SignalR.WithMessages.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Casgem.SignalR.WithMessages.Controllers
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
            return RedirectToAction("Index","Message");
        }

        public IActionResult Privacy()
        {
            return RedirectToAction("Index", "Message");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return RedirectToAction("Index", "Message");
        }
    }
}