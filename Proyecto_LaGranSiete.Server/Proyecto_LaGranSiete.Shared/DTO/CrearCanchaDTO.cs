using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.Shared.DTO
{
    public class CrearCanchaDTO
    {
        [Required(ErrorMessage = "El nombre de la cancha es obligatorio")]
        [MaxLength(20, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? NombreCancha { get; set; }

        //Disponibilidad para el usuario (reservada / libre)

        [Required(ErrorMessage = "El campo disponibilidad es obligatorio")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public int? Disponibilidad { get; set; } //cantidad dde personas por canchas
    }
}
