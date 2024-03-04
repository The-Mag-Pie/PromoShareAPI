using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PromoShareAPI.Models
{
    [Table("Images")]
    public class ImageModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public required string Image_B64 { get; set; }
    }
}
