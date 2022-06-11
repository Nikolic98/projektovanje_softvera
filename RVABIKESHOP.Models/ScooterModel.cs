using System.ComponentModel.DataAnnotations;

namespace ESCOOTERRENT.Models
{
    public class ScooterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        public bool Available { get; set; }
    }
}