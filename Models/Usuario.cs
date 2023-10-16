using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALMIR071023.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nome { get; set; }
        [StringLength(11)]
        public string cpf { get; set; }
    }
}
