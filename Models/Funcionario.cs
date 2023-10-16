using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALMIR071023.Models
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        [Required]
        [Key]
        public int Cod { get; set; }

        [Required]
        [StringLength(50)]
        public string nome { get; set; }

        [Required]
        [StringLength(10)]
        public string cargo { get; set; }
    }
}
