using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiAIblog.webUI.Controllers
{
    public class ArticleController : Controller
    {
    public IActionResult ArticleDetail()
    {
      return View();
    }

    public IActionResult ArticleList()
    {
      return View();
    }
    public IActionResult ArticleListByCategory()
    {
      return View();
    }
        public IActionResult About()
        {
            return View();
        }
    }
}