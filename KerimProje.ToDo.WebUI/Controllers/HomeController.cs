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
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(ITaskService taskService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _taskService = taskService;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SignIn(AppUserSignInModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Username);
                if (user != null)
                {
                    var identityResult = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

                    if (identityResult.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        if (userRoles.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home", new { area = "Member" });
                        }
                    }
                }
                ModelState.AddModelError("", "Username or password is wrong!");
            }
            return View("Index", model);
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
