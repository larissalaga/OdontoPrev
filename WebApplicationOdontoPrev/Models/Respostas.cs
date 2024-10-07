using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOdontoPrev.Models
{
    [Table("T_ODTP_RESPOSTAS")]
    public class Respostas
    {
        [Key] 
        [Required]
        [Column("id_resposta")]
        public int IdResposta { get; set; }

        [Required]
        [Column("ds_resposta")]
        [MaxLength(400)]
        public string DsResposta { get; set; } = string.Empty;

        [Required]
        [Column("dt_data_resposta")]
        [DataType(DataType.DateTime)]
        public DateTime DtDataResposta { get; set; }

        [Required]
        [ForeignKey("Perguntas")]
        public int IdPergunta { get; set; }

        public Perguntas? Perguntas { get; set; }

        [Required]
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
        public Paciente? Paciente { get; set; }
    }
}   