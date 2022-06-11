using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ESCOOTERRENT.Data
{
    [Table("e_scooter")]
    public class Scooter : Base
    {
        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("price")]
        [Required]
        public int Price { get; set; }

        [Column("type_id")]
        [Required]
        public int TypeId { get; set; }

        [Column("available")]
        [Required]
        public bool Available { get; set; }
    }
}