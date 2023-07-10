using Microsoft.AspNetCore.Mvc;

namespace Profitify_web.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
