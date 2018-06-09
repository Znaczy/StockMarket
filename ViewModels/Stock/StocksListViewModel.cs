using System.Collections.Generic;

namespace StockMarket.ViewModels
{
    public class StocksListViewModel
    {
        public StocksListViewModel()
        {
            Stocks = new List<StockViewModel>();
        }

        public List<StockViewModel> Stocks;
    }
}
