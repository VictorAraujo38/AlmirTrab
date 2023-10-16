using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALMIR071023.Models
{
    [Table("Vendas")]
    public class Venda
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(1)]
        public string status_venda { get; set; }

    }
}
