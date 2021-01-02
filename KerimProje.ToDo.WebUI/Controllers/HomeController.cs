using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using KerimProje.ToDo.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KerimProje.ToDo.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(ITaskService taskService, UserManager<AppUser> userManager)
        {
            _taskService = taskService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AppUserAddViewModel model)
        {
            if (ModelState.IsValid)
            {

                AppUser user = new AppUser()
                {
                    UserName = model.Username,
                    Email = model.Email,
                    Name = model.Name,
                    Surname = model.Surname
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var addRoleResult = await _userManager.AddToRoleAsync(user, "Member");
                    if (addRoleResult.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }
                    foreach (var item in addRoleResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

            }
            return View(model);
        }

    }
}
