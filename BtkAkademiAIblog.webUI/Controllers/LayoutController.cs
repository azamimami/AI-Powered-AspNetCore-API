using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiAIblog.webUI.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}