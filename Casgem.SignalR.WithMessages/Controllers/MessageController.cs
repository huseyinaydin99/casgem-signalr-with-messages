using Microsoft.AspNetCore.Mvc;

namespace Casgem.SignalR.WithMessages.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
