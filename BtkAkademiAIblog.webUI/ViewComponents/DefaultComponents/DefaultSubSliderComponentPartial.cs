using Microsoft.AspNetCore.Mvc;
namespace BtkAkademiAIblog.webUI.ViewComponents
{
    public class DefaultSubSliderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}