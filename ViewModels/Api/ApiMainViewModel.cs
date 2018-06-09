using System.Collections.Generic;

namespace StockMarket.ViewModels
{
    public class ApiMainViewModel
    {
        public int symbols_requested { get; set; }
        public int symbols_returned { get; set; }
        public List<ApiDataViewModel> data { get; set; }
    }
}