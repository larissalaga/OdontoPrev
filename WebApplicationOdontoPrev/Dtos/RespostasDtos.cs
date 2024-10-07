using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOdontoPrev.Dtos
{
    public class RespostasDtos
    {
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

        [Required]
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
    }
}
