using Microsoft.AspNetCore.Mvc;

namespace APIproject.WebUI.ViewComponents.DefaultMenuViewComponentPartial
{
    public class _DefaultMenuViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
