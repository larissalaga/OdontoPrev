using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOdontoPrev.Models
{
    [Table("T_ODTP_ANALISE_RAIO_X")]
    public class AnaliseRaioX
    {
        [Key]
        [Required]        
        [Column("id_analise_raio_x")]
        public int IdAnaliseRaioX { get; set; }

        [Required]
        [Column("id_paciente")]
        public string DsAnaliseRaioX { get; set; } = string.Empty;

        [Required]
        [Column("ds_analise_raio_x")]
        [DataType(DataType.DateTime)]
        public DateTime DtAnaliseRaioX { get; set; } 

        [Required]
        [ForeignKey("Raio_X")]
        public int IdRaioX { get; set; }
        public RaioX? RaioX { get; set; }
    }
}