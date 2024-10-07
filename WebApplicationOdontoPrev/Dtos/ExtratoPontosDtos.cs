using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOdontoPrev.Dtos
{
    public class ExtratoPontosDtos
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DtExtrato { get; set; }

        [Required]
        [MaxLength(10)]
        public int NrNumeroPontos { get; set; }

        public string DsMovimentacao { get; set; } = string.Empty;

        [Required]
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
    }
}
