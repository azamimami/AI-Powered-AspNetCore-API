using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiAIblog.webUI.ViewComponents.BlogDetailComponents
{
    public class BlogDetailComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}