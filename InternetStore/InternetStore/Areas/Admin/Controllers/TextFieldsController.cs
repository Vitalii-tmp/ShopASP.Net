using InternetStore.Domain;
using InternetStore.Domain.Entities;
using InternetStore.Services;
using Microsoft.AspNetCore.Mvc;


namespace InternetStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataManager dataManager;
        public TextFieldsController(DataManager dataManager, ILogger<HomeController> logger)
        {
            this.dataManager = dataManager;
            _logger = logger;
        }

       
        public IActionResult Edit(string codeWord)

        {
            _logger.LogInformation("EDIT CALL 1!");
            var entity = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextField model)
        {
            _logger.LogInformation("EDIT CALL 2!");
            if (ModelState.IsValid)
            {
                dataManager.TextFields.SaveTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

      
    }

}

