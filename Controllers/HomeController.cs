using Microsoft.AspNetCore.Mvc;

namespace StockMarket.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}