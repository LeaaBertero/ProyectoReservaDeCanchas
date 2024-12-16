using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data.Entity
{
    [Index(nameof(EquipoDosId), Name = "EquipoDosId", IsUnique = true)]
    [Index(nameof(NombreEquipoDos), Name = "EquipoDos_NombreEquipoDos", IsUnique = false)]

    public class EquipoDos : EntityBase
    {
        #region Entidad Equipo Dos
        //----------------------------------------------
        //Clave primaria de la tabla
        public int EquipoDosId { get; set; }

        //----------------------------------------------
        //atributos de la tabla
        [Required(ErrorMessage = "El nombre del equipo es obligatorio")]
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}")]
        public string? NombreEquipoDos { get; set; }

        //----------------------------------------------
        //Clave foranea de la tabla

        public int PartidoId { get; set; }
        public Partido Partidos { get; set; }

      


        public List<Reserva> Reservas { get; set; } = new List<Reserva>();
        public List<Pago> Pagos { get; set; } = new List<Pago>();
        #endregion
    }
}
