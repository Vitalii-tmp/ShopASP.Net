using InternetStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using InternetStore.Domain;
using Microsoft.AspNetCore.Mvc.Routing;

namespace InternetStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataManager _dataManager;

        public HomeController(ILogger<HomeController> logger, DataManager dataManager)
        {
            _logger = logger;
            _dataManager = dataManager;
            
        }

        public IActionResult Index()
        {
            return View(_dataManager.TextFields.GetTextFieldByCodeWord("HomePage"));
        }

        public IActionResult Catalog() => View(_dataManager.TextFields.GetTextFieldByCodeWord("CatalogPage"));

        public IActionResult Contacts() => View(_dataManager.TextFields.GetTextFieldByCodeWord("ContactsPage"));



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}