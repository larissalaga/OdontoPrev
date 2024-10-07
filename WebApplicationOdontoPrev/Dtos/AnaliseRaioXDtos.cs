using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplicationOdontoPrev.Models;

namespace WebApplicationOdontoPrev.Dtos
{
    public class AnaliseRaioXDtos
    {
        [Required]
        public string DsAnaliseRaioX { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DtAnaliseRaioX { get; set; }

        [Required]
        [ForeignKey("Raio_X")]
        public int IdRaioX { get; set; }
        public RaioX? RaioX { get; set; }  
    }
}
