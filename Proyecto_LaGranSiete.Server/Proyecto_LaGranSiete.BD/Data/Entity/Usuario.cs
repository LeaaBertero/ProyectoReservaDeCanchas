using Azure.Core.Pipeline;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    //[Index(nameof(Nombre), nameof(Apellido), nameof(UsuarioId), Name = "UsuarioId_UQ", IsUnique = true)]
    public class Usuario : EntityBase
    {
        //Clave primaria de la tabla
        public int UsuarioId { get; set; }


        //----------------------------------------------------
        //Propiedades de la tabla
        //----------------------------------------------------
        [Required(ErrorMessage = "El campo nombre, es obligatorio")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El apellido, es obligatorio")]
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "La fecha Nacimiento, es obligatoria")]
        public DateOnly FechaNacimiento { get; set; }
       

        [Required(ErrorMessage = "El teléfono, es obligatorio - (con guión despues del 351)")]
        [MaxLength(25, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Telefono { get; set; } //Telefono

        [Required(ErrorMessage = "El e-mail, es obligatorio")]
        [MaxLength(150, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? CorreoElectronico { get; set; }

        [Required(ErrorMessage = "El prentesco, es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? Parentesco { get; set; }

        //public List<Usuario> Usuarios { get; set; } 
    }
}
