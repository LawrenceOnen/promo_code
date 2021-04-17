using System.ComponentModel.DataAnnotations;

namespace Promocodes.Models
{
    public class Service
    {

        //Services data
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength (50)]
        public string Name { get; set; }

        [MaxLength (255)]
        public string Description { get; set; }

        public string Code { get; set; }
        public bool IsActivated { get; set; }

    }
}