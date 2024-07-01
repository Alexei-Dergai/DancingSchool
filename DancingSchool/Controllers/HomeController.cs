using DancingSchool.Models;
using DancingSchool_DataAccess.Repository.IRepository;
using DancingSchool_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DancingSchool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IFeedBackRepository _feedRepo;
        public HomeController(ILogger<HomeController> logger, IFeedBackRepository feedRepo)
        {
            _logger = logger;
            _feedRepo = feedRepo;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Successful(Feedback obj)
        {
            if (ModelState.IsValid)
            {
                _feedRepo.Add(obj);
                _feedRepo.Save();
            }
            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
