using System.ComponentModel.DataAnnotations;

namespace Api.Microservice.Cupon.Models.Dto
{
    public class CuponDto
    {
        public int CuponId { get; set; }
        public string CuponCode { get; set; }
        public double PorcentajeDescuento { get; set; }
        public int DescuentoMinimo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
