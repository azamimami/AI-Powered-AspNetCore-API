using Microsoft.AspNetCore.Mvc;
namespace BtkAkademiAIblog.webUI.ViewComponents
{
    public class DefaultTradingVideoPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}