using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiAIblog.webUI.ViewComponents.DefaultComponents
{
    public class DefaultGetCategoriesWithLastArticleComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}