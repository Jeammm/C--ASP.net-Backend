using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "Symbol must be at least 2 character long.")]
        [MaxLength(10, ErrorMessage = "Symbol must be at most 10 characters long.")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MinLength(2, ErrorMessage = "Company name must be at least 2 characters long.")]
        [MaxLength(100, ErrorMessage = "Company name must be at most 100 characters long.")]
        public string CompanyName{ get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Purchase price must be greater than 0.")]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 100, ErrorMessage = "Last dividend must be greater than 0.")]
        public decimal LastDiv { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Industry must be at least 2 characters long.")]
        [MaxLength(50, ErrorMessage = "Industry must be at most 50 characters long.")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(0, 5_000_000_000_000, ErrorMessage = "Market cap must be between 0 and 5 trillion.")]
        
        public long MarketCap { get; set; }
    }
}