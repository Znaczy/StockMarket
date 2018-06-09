using System.ComponentModel.DataAnnotations;

namespace StockMarket.ViewModels
{
    public class ApiDataViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string name { get; set; }

        [Required]
        [MaxLength(10)]
        public string symbol { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [MaxLength(10)]
        public string price { get; set; }

        [Required]
        [MaxLength(6)]
        public int Unit { get; set; }

        public string currency { get; set; }
        public string price_open { get; set; }
        public string day_high { get; set; }
        public string day_low { get; set; }
        public string __invalid_name__52_week_high { get; set; }
        public string __invalid_name__52_week_low { get; set; }
        public string day_change { get; set; }
        public string change_pct { get; set; }
        public string close_yesterday { get; set; }
        public string market_cap { get; set; }
        public string volume { get; set; }
        public string last_trade_time { get; set; }
    }
}