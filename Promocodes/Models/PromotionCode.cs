using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Promocodes.Models
{
    public class PromotionCode
    {

        //Services data
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("varchar(50)")]
        public string Name { get; set; }
        [Column("varchar(150)")]
        public string Description { get; set; }

        [Required]
        [Column("varchar(10)")]
        public string Code { get; set; }
        public bool IsActivated { get; set; }

    }
}