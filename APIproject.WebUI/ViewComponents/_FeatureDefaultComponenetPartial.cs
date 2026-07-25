using Microsoft.AspNetCore.Mvc;

namespace APIproject.WebUI.ViewComponents
{
    public class _FeatureDefaultComponenetPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
