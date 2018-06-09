using System.Linq;
using StockMarket.Data;
using StockMarket.Data.Models;
using StockMarket.ViewModels;

namespace StockMarket.Services
{
    public class StockData : IStockData
    {
        private readonly StockMarketContext _context;

        public StockData(StockMarketContext context)
        {
            _context = context;
        }

        public StocksListViewModel GetAllStocks()
        {
            var query = GetStocks();
            var vm = new StocksListViewModel();

            if (!query.Any()) return vm;

            foreach(var model in query)
            {
                var stock = Map(model);
                vm.Stocks.Add(stock);
            }

            return vm;
        }

        private StockViewModel Map(Stock model)
        {
            return new StockViewModel
            {
                Id = model.Id,
                Price = model.Price,
                Unit = model.Unit,
                PriceOpen = model.PriceOpen,
                DayHigh = model.DayHigh,
                DayLow = model.DayLow,
                FiftyTwoWeekHigh = model.FiftyTwoWeekHigh,
                FiFtyTwoWeekLow = model.FiFtyTwoWeekLow,
                DayChange = model.DayChange,
                ChangePct = model.ChangePct,
                CloseYesterday = model.CloseYesterday,
                MarketCap = model.MarketCap,
                Volume = model.Volume,
                LastTradeTime = model.LastTradeTime
            };
        }

        private IQueryable<Stock> GetStocks()
        {
            return _context.Stocks.AsQueryable();
        }
    }
}
