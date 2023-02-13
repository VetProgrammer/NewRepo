using DepInjDemoMVC.Models;
using DepInjDemoMVC.Services.NonDatabase;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DepInjDemoMVC.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
        private readonly IEmailSenderService _service;
        public HomeController(IEmailSenderService service)
        {
                 _service = service;
            
        }

        public IActionResult Index()
        {
            _service.SendEmail("Hello World");
            ViewData["Message"] = _service.Message;
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