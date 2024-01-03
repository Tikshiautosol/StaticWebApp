using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using Microsoft.Extensions.Configuration;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private  IConfiguration Configuration;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = Configuration.GetValue<string>("Title");
            ViewData["CustName"] = Configuration.GetValue<string>("CustomerName");

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = Configuration.GetValue<string>("Title");
            ViewData["CustName"] = Configuration.GetValue<string>("CustomerName");

            return View();
        }

        public IActionResult Contactus()
        {
            ViewData["Title"] = Configuration.GetValue<string>("Title");
            ViewData["CustName"] = Configuration.GetValue<string>("CustomerName");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
