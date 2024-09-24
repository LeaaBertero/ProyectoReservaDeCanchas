using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.Shared.DTO
{
    public class CrearPagosDTO
    {
        [Required(ErrorMessage = "El monto de pago es obligatorio")]
        [MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public double? Monto_Pago { get; set; }


        [Required(ErrorMessage = "El método de pago es obligatorio")]
        [MaxLength(15, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? MetodoPagado { get; set; } //puede ser (int) también el tipo de dato



        [Required(ErrorMessage = "La fecha del pago es obligatoria")]
        [MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateOnly FechaPago { get; set; }
    }
}

