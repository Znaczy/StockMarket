using System;

namespace StockMarket.ViewModels
{
    public class StockViewModel
    {
        public int Id { get; set; }
        public Decimal Price { get; set; }
        public int Unit { get; set; }
        public Decimal PriceOpen { get; set; }
        public Decimal DayHigh { get; set; }
        public Decimal DayLow { get; set; }
        public Decimal FiftyTwoWeekHigh { get; set; }
        public Decimal FiFtyTwoWeekLow { get; set; }
        public Decimal DayChange { get; set; }
        public Decimal ChangePct { get; set; }
        public Decimal CloseYesterday { get; set; }
        public int MarketCap { get; set; }
        public int Volume { get; set; }
        public DateTime LastTradeTime { get; set; }
    }
}