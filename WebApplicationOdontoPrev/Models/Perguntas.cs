using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOdontoPrev.Repositories.Interfaces;

namespace WebApplicationOdontoPrev.Models
{
    [Table("T_ODTP_PERGUNTAS")]
    public class Perguntas
    {
        [Key]
        [Required]
        [Column("id_pergunta")]
        public int IdPergunta { get; set; }

        [Required]
        [Column("ds_pergunta")]
        [MaxLength(300)]
        public string DsPergunta { get; set; } = string.Empty;
    }
}   