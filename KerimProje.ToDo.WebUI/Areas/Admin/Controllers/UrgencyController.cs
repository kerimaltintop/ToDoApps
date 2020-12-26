using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using KerimProje.ToDo.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrgencyController : Controller
    {
        private readonly IUrgencyService _urgencyService;
        public UrgencyController(IUrgencyService urgencyService)
        {
            _urgencyService = urgencyService;
        }

        public IActionResult Index()
        {
            List<Urgency> urgencys = _urgencyService.GetAll();

            List<UrgencyListViewModel> model = new List<UrgencyListViewModel>();

            foreach (var item in urgencys)
            {
                UrgencyListViewModel urgencyListViewModel = new UrgencyListViewModel();
                urgencyListViewModel.Id = item.Id;
                urgencyListViewModel.Definition = item.Definition;

                model.Add(urgencyListViewModel);
            }
            return View(model);
        }


        public IActionResult AddUrgency()
        {
            return View(new UrgencyAddViewModel());
        }

        [HttpPost]
        public IActionResult AddUrgency(UrgencyAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _urgencyService.Save(new Urgency()
                {
                    Definition = model.Definition
                });
                return RedirectToAction("Index");
            }
            return View();
        }




    }
}
