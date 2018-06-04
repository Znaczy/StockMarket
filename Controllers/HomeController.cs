using Microsoft.AspNetCore.Mvc;

namespace WebCoreMvcFromScratch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}