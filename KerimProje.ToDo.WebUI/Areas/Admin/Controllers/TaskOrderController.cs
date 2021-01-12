using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using KerimProje.ToDo.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class TaskOrderController : Controller
    {

        private readonly IAppUserService _appUserService;
        private readonly ITaskService _taskService;
        public TaskOrderController(IAppUserService appUserService, ITaskService taskService)
        {
            _appUserService = appUserService;
            _taskService = taskService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "taskOrder";
            //var model = _appUserService.GetNotAdmin();

            List<Task> task = _taskService.GetAllTable();
            List<TaskListAllViewModel> models = new List<TaskListAllViewModel>();
            foreach (var item in task)
            {
                TaskListAllViewModel model = new TaskListAllViewModel();
                model.Id = item.Id;
                model.Name = item.Name;
                model.Explanation = item.Explanation;
                model.CreationDate = item.CreationDate;
                model.AppUser = item.AppUser;
                model.Urgency = item.Urgency;
                model.Reports = item.Reports;
                models.Add(model);
            }

            return View(models);
        }
    }
}
