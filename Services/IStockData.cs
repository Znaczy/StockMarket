using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreMvcFromScratch.Models;

namespace WebCoreMvcFromScratch.Services
{
    public interface IStockData
    {
        IEnumerable<Stock> GetStocks();
    }
}