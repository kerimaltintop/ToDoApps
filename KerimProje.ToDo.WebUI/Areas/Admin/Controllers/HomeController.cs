using Microsoft.AspNetCore.Mvc;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
