using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using KerimProje.ToDo.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
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

        public IActionResult UpdateTask(int id)
        {
            TempData["Active"] = "task";
            var task = _taskService.GetById(id);
            TaskUpdateViewModel model = new TaskUpdateViewModel
            {
                Id = task.Id,
                Name = task.Name,
                Explanation = task.Explanation,
                UrgencyId = task.UrgencyId
            };
            ViewBag.UrgencyList = new SelectList(_urgencyService.GetAll(), "Id", "Definition", task.UrgencyId);
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateTask(TaskUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _taskService.Update(new Task
                {
                    Id = model.Id,
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
