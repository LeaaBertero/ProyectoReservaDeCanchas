using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    [Index(nameof(EquipoUnoId), 
    Name = "EquipoUnoId", IsUnique = true)]
    [Index(nameof(NombreEquipoUno),Name = "EquipoUno_NombreEquipoUno", IsUnique = false)]

    public class EquipoUno : EntityBase
    {
        //--------------------------------------------
        //Clave primaria de la tabla
        public int EquipoUnoId { get; set; }
        //--------------------------------------------

        //Atributos de la tabla
        [Required(ErrorMessage = "El nombre del equipo es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? NombreEquipoUno { get; set; }
        //--------------------------------------------

        public int PartidoId { get; set; }
        public Partido Partidos { get; set; }



        public List<Reserva> Reservas { get; set; } = new List<Reserva>();
        public List<Pago> Pagos { get; set; } = new List<Pago>();
    }
}
