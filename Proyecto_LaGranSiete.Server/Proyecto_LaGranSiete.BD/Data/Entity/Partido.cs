using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    //Indices de la tabla
    [Index(nameof(PartidoId), Name = "PartidosId", IsUnique = true)]
    [Index(nameof(FechaHoraPartidos),
    Name = "Partido_FechaHoraPartidos", IsUnique = false)]

    public class Partido : EntityBase
    {
        //Clave primaria de la tabla Partidos
        public int PartidoId { get; set; }

        //clave foránea de la tabla Reserva

        //-----------------------------------------------------
        //Propiedades de la tabla
        //-----------------------------------------------------


        [Required(ErrorMessage = "La fecha y hora del partido es obligatorio")]
        //[MaxLength(30, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateTime FechaHoraPartidos { get; set; }
        //-----------------------------------------------------

        //Clave foranea de la tabla
        

        

        //--------------------------------------------------------
        //Relaciones entre tablas
        //Clave primaria de la tabla (Reserva)
       
        

        public int CanchaId { get; set; }
        public Cancha Canchas { get; set; }

        
        //--------------------------------------------------------
    }
}
        
       

      

        


       



       

