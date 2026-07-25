using Microsoft.AspNetCore.Mvc;

namespace APIproject.WebUI.ViewComponents
{
    public class _ServiceDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
