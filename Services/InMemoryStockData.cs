using System.Collections.Generic;
using System.Linq;

namespace StockMarket.Services
{
    public class InMemoryStockData : IStockData
    {
        List<ApiData> _stocks;

        public InMemoryStockData()
        {
            _stocks = new List<ApiData>()
            {
                    new ApiData { Name = "Future Processing", Code = StockCode.FP, Unit = 1, Id = (int)StockCode.FP },
                    new ApiData { Name = "FP Lab", Code = StockCode.FPL, Unit = 100, Id = (int)StockCode.FPL },
                    new ApiData { Name = "Progress Bar", Code = StockCode.PGB, Unit = 1, Id = (int)StockCode.PGB },
                    new ApiData { Name = "FP Coin", Code = StockCode.FPC, Unit = 1, Id = (int)StockCode.FPC },
                    new ApiData { Name = "FP Adventure", Code = StockCode.FPA, Unit = 50, Id = (int)StockCode.FPA },
                    new ApiData { Name = "Deadline 24", Code = StockCode.DL24, Unit = 100, Id = (int)StockCode.DL24 }
            };
        }

        public IQueryable<ApiData> GetStocks()
        {
            return _stocks.OrderBy(s =>s.Id).AsQueryable();
        }
    }
}