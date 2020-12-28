using KerimProje.ToDo.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KerimProje.ToDo.WebUI.Controllers
{
    public class HomeController : Controller
    {
        ITaskService _taskService;
        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
