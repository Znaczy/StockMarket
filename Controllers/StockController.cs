using Microsoft.AspNetCore.Mvc;
using WebCoreMvcFromScratch.Models;
using WebCoreMvcFromScratch.Services;

namespace WebCoreMvcFromScratch.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockData _stockData;
        public StockController(IStockData stockData)
        {
            _stockData = stockData;
        }
        public IActionResult Index()
        {
            var model = _stockData.GetStocks();

            return View(model);
        }
    }
}