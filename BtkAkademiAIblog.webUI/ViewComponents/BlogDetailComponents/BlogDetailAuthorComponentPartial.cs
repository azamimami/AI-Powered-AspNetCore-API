using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiAIblog.webUI.ViewComponents.DefaultComponents
{
    public class BlogDetailAuthorComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}