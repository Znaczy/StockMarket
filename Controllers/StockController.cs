using Microsoft.AspNetCore.Mvc;
using StockMarket.Services;

namespace StockMarket.Controllers
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
            var model = _stockData.GetAllStocks();

            return View(model);
        }
    }
}