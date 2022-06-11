using System.ComponentModel.DataAnnotations;

namespace ESCOOTERRENT.Models
{
    public class StoreModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string WorkingHours { get; set; }
    }
}