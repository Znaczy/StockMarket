using System.Collections.Generic;
using System.Linq;
using WebCoreMvcFromScratch.Models;

namespace WebCoreMvcFromScratch.Services
{
    public class InMemoryStocks : IStockData
    {
        List<Stock> _stocks;

        public InMemoryStocks()
        {
            _stocks = new List<Stock>()
            {
                    new Stock { Name = "Future Processing", Code = "FP", Unit = 1, Id = 1 },
                    new Stock { Name = "FP Lab", Code = "FPL", Unit = 100, Id = 2 },
                    new Stock { Name = "Progress Bar", Code = "PGB", Unit = 1, Id = 3 },
                    new Stock { Name = "FP Coin", Code = "FPC", Unit = 1, Id = 4 },
                    new Stock { Name = "FP Adventure", Code = "FPA", Unit = 50, Id = 5 },
                    new Stock { Name = "Deadline 24", Code = "DL24", Unit = 100, Id = 6 }
            };
        }

        public IEnumerable<Stock> GetStocks()
        {
            return _stocks.OrderBy(s =>s.Id);
        }
    }
}