using Microsoft.AspNetCore.Mvc;

namespace Profitify_web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
