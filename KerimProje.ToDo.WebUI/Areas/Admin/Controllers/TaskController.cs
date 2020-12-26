using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using KerimProje.ToDo.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace KerimProje.ToDo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TaskController : Controller
    {

        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "task";
            List<Task> tasks = _taskService.GetAll();
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
    }
}
