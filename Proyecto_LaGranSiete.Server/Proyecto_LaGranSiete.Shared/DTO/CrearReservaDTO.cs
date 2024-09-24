using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.Shared.DTO
{
    public class CrearReservaDTO
    {
        [Required(ErrorMessage = "La fecha y hora obligatoria")]
        [MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime FechaHoraReserva { get; set; }


        [Required(ErrorMessage = "La duración del alquiler es obligatoria")]
        [MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public int DuracionAlquiler { get; set; }


        [Required(ErrorMessage = "El campo Monto, es obligatorio")]
        [MaxLength(12, ErrorMessage = "Máximo número de caracteres {1}")]
        public int Monto { get; set; }


        [Required(ErrorMessage = "El campo método de pago, es obligatorio")]
        [MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? MetodoPago { get; set; } //puede ser (int) también


        [Required(ErrorMessage = "El campo estado de la reserva es obligatoria")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? EstadoReserva { get; set; }
    }
}
       


        


       


       


       
