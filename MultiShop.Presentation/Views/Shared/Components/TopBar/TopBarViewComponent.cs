using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Presentation.Views.Shared.Components.TopBar
{
    public class TopBarViewComponent : ViewComponent
    {    //TopBar
            public IViewComponentResult Invoke()
            {
                return View();
            }
    }
}
