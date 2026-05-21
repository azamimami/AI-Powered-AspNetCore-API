using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiAIblog.webUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}