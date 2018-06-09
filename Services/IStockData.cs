using StockMarket.ViewModels;

namespace StockMarket.Services
{
    public interface IStockData
    {
        StocksListViewModel GetAllStocks();
    }
}