using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PromoShareAPI.Models
{
    [Table("Promotions")]
    public class PromotionModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public required string Username { get; set; }

        public int? PhoneNumber { get; set; }

        public DateTime TimeCreated { get; set; } = DateTime.Now;
    }
}
