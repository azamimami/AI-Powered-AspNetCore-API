using Microsoft.AspNetCore.Mvc;
namespace BtkAkademiAIblog.webUI.ViewComponents
{
    public class SubFeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}