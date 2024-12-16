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
    [Index(nameof(PagoId), Name = "PagoId", IsUnique = true)]
    [Index(nameof(Monto_Pago), nameof(FechaPago),
    Name = "Pago_Monto_Pago_FechaPago", IsUnique = false)]

    public class Pago : EntityBase
    {
        #region entidad Pago
        public int PagoId { get; set; }

        //Clave primaria de la tabla

        //clave foranea de la tabla Reserva
       

        //------------------------------------------------------
        //Propiedades de la tabla
        //------------------------------------------------------
        
        
        public DateTime fechaHora { get; set; }

        [Required(ErrorMessage = "El monto de pago es obligatorio")]
        [MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public float? Monto_Pago { get; set; }


        [Required(ErrorMessage = "El método de pago es obligatorio")]
        //[MaxLength(15, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? MetodoPagado { get; set; } 



        [Required(ErrorMessage = "La fecha del pago es obligatoria")]
        //[MaxLength(10, ErrorMessage = "Máximo número de caracteres {1}")]
        public DateOnly FechaPago { get; set; }

        [Required(ErrorMessage = "El monto del pago es obligatoria")]
        public float Monto { get; set; }
        //-------------------------------------------------------


        //--------------------------------------------------------


        //Relaciones entre tablas
        //Clave primaria de la tabla (Reserva)

     

        public int EquipoId { get; set; }
        public Equipo Equipos { get; set; }

        public int PartidoId { get; set; }
        public Partido Partidos { get; set; }

        public int CanchaId { get; set; }
        public Cancha Canchas { get; set; }


        //--------------------------------------------------------
        #endregion
    }
}
        



