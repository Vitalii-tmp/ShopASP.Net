using InternetStore.Domain;
using Microsoft.AspNetCore.Mvc;

namespace InternetStore.Models.ViewComponents
{
    public class BottombarViewComponent : ViewComponent
    {
      private readonly DataManager _dataManager;

      public BottombarViewComponent(DataManager dataManager)
      {
            _dataManager = dataManager;
      }

      public Task<IViewComponentResult> InvokeAsync()
      {
          return Task.FromResult((IViewComponentResult)View("Default", _dataManager.ProductItems.GetProductItems()));
      }
    }
}
