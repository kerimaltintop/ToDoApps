using Microsoft.AspNetCore.Mvc;

namespace KerimProje.ToDo.Web.ViewComponents
{
    public class Products : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
