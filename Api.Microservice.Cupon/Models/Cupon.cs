using System.ComponentModel.DataAnnotations;

namespace Api.Microservice.Cupon.Models
{
    public class Cupon
    {
        [Key]
        public int CuponId {  get; set; }
        [Required]
        public string CuponCode {  get; set; }
        [Required]
        public double PorcentajeDescuento {  get; set; }
        public int DescuentoMinimo {  get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFin { get; set; }
    }
}
