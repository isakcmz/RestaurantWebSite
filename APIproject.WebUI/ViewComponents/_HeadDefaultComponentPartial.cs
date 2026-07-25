using Microsoft.AspNetCore.Mvc;

namespace APIproject.WebUI.ViewComponents
{
    public class _HeadDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
