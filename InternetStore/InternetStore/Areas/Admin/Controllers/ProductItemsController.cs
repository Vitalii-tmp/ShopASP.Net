using System;
using System.IO;
using InternetStore.Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InternetStore.Domain.Entities;
using InternetStore.Services;

namespace InternetStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public ProductItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new ProductItem() : dataManager.ProductItems.GetProductItemById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(ProductItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "img/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.ProductItems.SaveProductItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            else
            {
                return View(model);
            }
            
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.ProductItems.DeleteProductItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}