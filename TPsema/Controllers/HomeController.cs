using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TPsema.Models;

namespace TPsema.Controllers
{
    public class Mediator
    {
        public string GetIndexMessage()
        {
            return "Your application description page.";
        }

        public string GetPrivacyMessage()
        {
            return "Your contact page.";
        }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Mediator _mediator;

        public HomeController(ILogger<HomeController> logger, Mediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public IActionResult Index
        {
            get
            {
                ViewBag.Message = _mediator.GetIndexMessage();

                return View();
            }
        }

        public IActionResult Privacy()
        {

            ViewBag.Message = _mediator.GetPrivacyMessage();

            return View();
        }

       // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
       // {
      //      return View(new ViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      //  }
    }
}