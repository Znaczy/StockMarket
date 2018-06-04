using Microsoft.AspNetCore.Mvc;
using WebCoreMvcFromScratch.Models;
using WebCoreMvcFromScratch.Services;
using WebCoreMvcFromScratch.ViewModels;

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
            var model = new StockViewModel();
            model.Stocks = _stockData.GetStocks();
            return View(model);
        }
    }
}