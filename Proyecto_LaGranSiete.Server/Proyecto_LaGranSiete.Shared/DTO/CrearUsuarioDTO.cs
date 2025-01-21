using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.Shared.DTO
{
    public class CrearUsuarioDTO
    {
        [Required(ErrorMessage = "El campo nombre, es obligatorio")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El campo apellido, es obligatorio")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "La fecha Nacimiento, es obligatoria")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El campo teléfono, es obligatorio")]
        [MaxLength(25, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? Telefono { get; set; } //Telefono

        [Required(ErrorMessage = "El campo e-mail, es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? CorreoElectronico { get; set; }

        [Required(ErrorMessage = "El campo prentesco, es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Parentesco { get; set; }

    }
}
