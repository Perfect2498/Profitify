using Microsoft.AspNetCore.Mvc;

namespace Profitify_web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
