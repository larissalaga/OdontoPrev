using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOdontoPrev.Dtos
{
    public class RaioXDtos
    {
        [Required]
        public byte[] DsRaioX { get; set; } = new byte[0];

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DtDataRaioX { get; set; }

        [Required]
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
    }
}
