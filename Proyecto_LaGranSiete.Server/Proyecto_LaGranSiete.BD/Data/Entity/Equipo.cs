using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    //Indices de la tabla
    [Index(nameof(EquipoId), Name = "EquipoId", IsUnique = true)]
    [Index(nameof(NombreEquipos), nameof(Integrantes),
    Name = "Equipo_NombreEquipos_Integrantes", IsUnique = false)]

    public class Equipo : EntityBase
    {
        //Clave primaria de la tabla
        //public int EquipoId { get; set; }
        public int EquipoId { get; set; }
        
                                                            

        //-------------------------------------------------------
        //Propiedades de la tabla
        //-------------------------------------------------------

        [Required(ErrorMessage = "El nombre del equipo es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? NombreEquipos { get; set; }
        //-------------------------------------------------------
        //cantidad de integrantes que conforman el equipo
        //-------------------------------------------------------

        [Required(ErrorMessage = "El campo integrantes es obligatorio (especificar en número), máximo por equipo 7 personas")]
        [MaxLength(2, ErrorMessage = "Máximo de jugadores por equipo")]
        public int Integrantes { get; set; }
        //-------------------------------------------------------

        public int PartidoId { get; set; }
        public Partido Partidos { get; set; }

       
    }
}


