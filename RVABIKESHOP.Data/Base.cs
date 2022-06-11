using System.ComponentModel.DataAnnotations.Schema;

namespace ESCOOTERRENT.Data
{
    public class Base
    {
        [Column("id")]
        public int Id { get; set; }
    }
}