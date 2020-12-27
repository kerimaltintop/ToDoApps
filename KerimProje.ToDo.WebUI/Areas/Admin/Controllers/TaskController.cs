using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using KerimProje.ToDo.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly IUrgencyService _urgencyService;
        public TaskController(ITaskService taskService, IUrgencyService urgencyService)
        {
            _taskService = taskService;
            _urgencyService = urgencyService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "task";
            List<Task> tasks = _taskService.GetWithUrgencyNotComplete();
            List<TaskListViewModel> taskListViewModels = new List<TaskListViewModel>();
            foreach (var item in tasks)
            {
                TaskListViewModel model = new TaskListViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Explanation = item.Explanation,
                    Status = item.Status,
                    CreationDate = item.CreationDate,
                    UrgencyId = item.UrgencyId,
                    Urgency = item.Urgency
                };
                taskListViewModels.Add(model);
            }
            return View(taskListViewModels);
        }
        public IActionResult AddTask()
        {
            TempData["Active"] = "task";
            ViewBag.UrgencyList = new SelectList(_urgencyService.GetAll(), "Id", "Definition");
            return View(new TaskAddViewModel());
        }
        [HttpPost]
        public IActionResult AddTask(TaskAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _taskService.Save(new Task
                {
                    Name = model.Name,
                    Explanation = model.Explanation,
                    UrgencyId = model.UrgencyId
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
