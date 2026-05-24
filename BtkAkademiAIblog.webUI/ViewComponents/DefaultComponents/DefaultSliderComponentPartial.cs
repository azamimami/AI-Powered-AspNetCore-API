using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiAIblog.webUI.ViewComponents.DefaultComponents
{
    public class DefaultSliderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}