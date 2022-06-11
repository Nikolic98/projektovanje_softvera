using System.ComponentModel.DataAnnotations;

namespace ESCOOTERRENT.Models
{
    public class TypeModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}