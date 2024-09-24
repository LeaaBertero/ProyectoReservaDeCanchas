using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.Shared.DTO
{
    public class CrearPartidosDTO
    {
        [Required(ErrorMessage = "La fecha y hora del partido es obligatorio")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime? FechaHoraPartidos { get; set; }
    }
}
