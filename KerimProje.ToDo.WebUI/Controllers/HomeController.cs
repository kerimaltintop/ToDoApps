using Microsoft.AspNetCore.Mvc;

namespace KerimProje.ToDo.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
