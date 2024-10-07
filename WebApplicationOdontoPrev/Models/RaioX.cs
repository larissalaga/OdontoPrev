using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace WebApplicationOdontoPrev.Models
{
    [Table("T_ODTP_RAIO_X")]
    public class RaioX
    {
        [Key]
        [Required]
        [Column("id_raio_x")]
        public int IdRaioX { get; set; }

        [Required]
        [Column("ds_raio_x")]
        public byte[] DsRaioX { get; set; } = new byte[0];

        [Required]
        [Column("dt_data_raio_x")]
        [DataType(DataType.DateTime)]
        public DateTime DtDataRaioX { get; set; }

        [Required]
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
        public Paciente? Paciente { get; set; }
    }
}