using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.Shared.DTO
{
    public class CrearEquiposDTO
    {
        [Required(ErrorMessage = "El nombre del equipo es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? NombreEquipos { get; set; }
        //-------------------------------------------------------
        //cantidad de integrantes que conforman el equipo
        //-------------------------------------------------------

        [Required(ErrorMessage = "El campo integrantes es obligatorio (especificar en número), máximo por equipo 7 personas")]
        [MaxLength(2, ErrorMessage = "Máximo número de caracteres {1}")]
        public int Integrantes { get; set; }
    }
}

