using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOdontoPrev.Models
{
    [Table("T_ODTP_EXTRATO_PONTOS")]
    public class ExtratoPontos
    {
        [Key]
        [Required]
        [Column("id_extrato_pontos")]
        public int IdExtratoPontos { get; set; }

        [Required]
        [Column("dt_extrato")]
        [DataType(DataType.DateTime)]
        public DateTime DtExtrato { get; set; }

        [Required]
        [Column("nr_numero_pontos")]
        [MaxLength(10)]
        public int NrNumeroPontos { get; set; }

        [Column("ds_movimentacao")]
        public string DsMovimentacao { get; set; } = string.Empty;

        [Required]
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
        public Paciente? Paciente { get; set; } 
    }
}   