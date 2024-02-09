using InternetStore.Domain;
using Microsoft.AspNetCore.Mvc;

namespace InternetStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.ProductItems.GetProductItems());
        }
    }
}
