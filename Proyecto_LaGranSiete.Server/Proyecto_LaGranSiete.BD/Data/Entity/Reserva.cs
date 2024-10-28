using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    [Index(nameof(UsuarioId), Name = "UsuarioId_UQ", IsUnique = true)]
    [Index(nameof(FechaHoraReserva), nameof(DuracionAlquiler), nameof(Monto), nameof(MetodoPago), nameof(EstadoReserva),
    Name = "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva", IsUnique = false)]


    public class Reserva : EntityBase
    {
        //Clave primaria de la tabla Reservas
        public int? ReservaId { get; set; }

        //----------------------------------------------------
        //Propiedades de la tabla
        //----------------------------------------------------
        //Para duplicar lineas Presionar (Control + D)


        //----------------------------------------------------

        [Required(ErrorMessage = "la fecha y hora de la reserva, es obligatoria")]
        public DateTime FechaHoraReserva { get; set; }


        [Required(ErrorMessage = "La duración del alquiler es obligatorio")]
        public int DuracionAlquiler { get; set; }


        [Required(ErrorMessage = "El monto es obligatorio")]
        public Decimal Monto { get; set; }


        [Required(ErrorMessage = "El método es obligatorio")]
        public string? MetodoPago { get; set; }


        [Required(ErrorMessage = "El estado de la reserva es obligatorio")]
        public bool? EstadoReserva { get; set; }





        //Tabla de referencia con Reserva
        public int? UsuarioId { get; set; }
        //public Usuario? Usuarios { get; set; }

        //Lista de reservas que lo usuarios realizaron
        
        public List<Reserva> Reservas { get; set; }


        //public int EquipoUnoId { get; set; }
        //public EquipoUno? EquipoUno { get; set; }


        //public int EquipoDosId { get; set; }
        //public EquipoDos? EquipoDos { get; set; }


        //public int PartidoId { get; set; }
        //public Partido? Partidos { get; set; }


        //public int PagoId { get; set; }
        //public Pago? Pagos { get; set; }


        //public int EquipoId { get; set; }
        //public Equipo? Equipos { get; set; }

        //Lista de las reservas realizadas por los usuarios
        //public List<Reserva> Reservas { get; set; } = new List<Reserva>();
       
    }
}


        

       




