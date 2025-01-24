using System.ComponentModel.DataAnnotations;

namespace autoparts.Models
{
    public class AddBalanceModel
    {
        [Required]
        [Range(1, 750000)]
        public decimal Amount { get; set; }
    }
} 