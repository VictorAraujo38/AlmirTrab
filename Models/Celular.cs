using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALMIR071023.Models
{

    [Table("Celulares")]
    public class Celular
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string marca { get; set; }

    }
}
