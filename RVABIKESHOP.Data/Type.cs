using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESCOOTERRENT.Data
{
    [Table("type")]
    public class Type : Base
    {
        [Column("name")]
        [Required]
        public string Name { get; set; }
    }
}