using System.Collections.Generic;
using WebCoreMvcFromScratch.Models;

namespace WebCoreMvcFromScratch.ViewModels
{
    public class StockViewModel
    {
        public IEnumerable<Stock> Stocks { get; set; }
    }
}