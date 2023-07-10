using Microsoft.AspNetCore.Mvc;

namespace Profitify_web.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
