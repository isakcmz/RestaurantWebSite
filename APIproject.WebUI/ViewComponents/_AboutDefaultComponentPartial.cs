using Microsoft.AspNetCore.Mvc;

namespace APIproject.WebUI.ViewComponents
{
    public class _AboutDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
