using Microsoft.AspNetCore.Mvc;
namespace BtkAkademiAIblog.webUI.ViewComponents
{
    public class SecondFeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}