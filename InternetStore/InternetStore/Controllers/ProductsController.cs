using System;
using InternetStore.Domain;
using Microsoft.AspNetCore.Mvc;

namespace InternetStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataManager dataManager;

        public ProductsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ProductItems.GetProductItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("CatalogPage");
            return View(dataManager.ProductItems.GetProductItems());
        }
    }
}