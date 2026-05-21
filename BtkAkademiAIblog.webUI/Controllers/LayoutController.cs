using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiAIblog.webUI.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Header()
        {
            return PartialView();
        }

        public IActionResult Footer()
        {
            return PartialView();
        }
    }
}