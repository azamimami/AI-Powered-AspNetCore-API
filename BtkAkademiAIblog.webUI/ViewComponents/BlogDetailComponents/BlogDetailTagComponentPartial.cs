using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiAIblog.webUI.ViewComponents.BlogDetailComponents
{
    public class BlogDetailTagComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}