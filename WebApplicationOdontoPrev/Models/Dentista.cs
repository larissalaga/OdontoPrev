using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOdontoPrev.Models
{
    [Table("T_ODTP_DENTISTA")]
    public class Dentista
    {
        [Key]
        [Required]
        [Column("id_dentista")]
        public int IdDentista { get; set; }

        [Required]
        [Column("nm_dentista")]
        [MaxLength(100)]
        public string NmDentista { get; set; } = string.Empty;

        [Required]
        [Column("ds_doc_identificacao")]
        [MaxLength(14)]
        public string DsDocIdentificacao { get; set; } = string.Empty;

        [Required]
        [Column("nr_telefone")]
        [MaxLength(30)]
        public string NrTelefone { get; set; } = string.Empty;

        [Required]
        [Column("ds_email")]
        [EmailAddress]
        [MaxLength(70)]
        public string DsEmail { get; set; } = string.Empty;

        [Required]
        [Column("ds_cro")]
        [MaxLength(20)]
        public string DsCro { get; set; } = string.Empty;
    }
}