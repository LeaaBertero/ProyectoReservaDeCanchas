using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data
{
    //Con presionar (Control + .), se despliega una lista de opciones, en la cual,
    //se debe seleccionar "Extraer Interfaz" y presionamos en Aceptar, 
    //dónde vamos a obtener la herencia de (EntityBase), IEntityBase 
    public class EntityBase : IEntityBase
    {
        #region Entidad Base para todas las tablas
        //Id de cada una de las tablas
        //[Required(ErrorMessage = "El id es obligatorio")]
        public int Id { get; set; }
        #endregion
    }
}
