using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESCOOTERRENT.Data
{
    [Table("store")]
    public class Store : Base
    {
        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("location")]
        [Required]
        public string Location { get; set; }

        [Column("working_hours")]
        [Required]
        public string WorkingHours { get; set; }
    }
}