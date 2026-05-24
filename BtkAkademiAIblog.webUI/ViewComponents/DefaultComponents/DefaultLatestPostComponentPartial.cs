using Microsoft.AspNetCore.Mvc;
namespace BtkAkademiAIblog.webUI.ViewComponents
{
    public class DefaultLatestPostComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}