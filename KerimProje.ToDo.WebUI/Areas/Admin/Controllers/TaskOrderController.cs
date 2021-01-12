using KerimProje.ToDo.Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class TaskOrderController : Controller
    {
    
        IAppUserService _appUserService;
        public TaskOrderController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "taskOrder";
            var model = _appUserService.GetNotAdmin();
            return View(model);
        }
    }
}
