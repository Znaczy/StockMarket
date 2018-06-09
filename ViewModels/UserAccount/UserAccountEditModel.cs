using System.ComponentModel.DataAnnotations;

namespace StockMarket.ViewModels
{
    public class UserAccountEditModel
    {
        [Required, MinLength(2), MaxLength(80)]
        public string Name { get; set; }

        [Required, MinLength(2), MaxLength(80)]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "100000000")]
        public decimal Money { get; set; }
    }
}
