using System.ComponentModel.DataAnnotations;

namespace Promocodes.Models
{
    public class PromotionCode
    {

        //Services data
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        [Required]
        public string Code { get; set; }
        public bool IsActivated { get; set; }

    }
}