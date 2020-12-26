using Microsoft.AspNetCore.Mvc;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Controllers
{
    public class TaskController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            TempData["Active"] = "task";
            return View();
        }
    }
}
