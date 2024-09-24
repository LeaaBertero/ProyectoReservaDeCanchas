using Microsoft.AspNetCore.Mvc;
using Proyecto_LaGranSiete.BD.Data.Entity;

namespace Proyecto_LaGranSiete.Server.Repositorio
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Task<ActionResult<int>> Insert(EquipoUno entidad);
        Task<ActionResult<int>> Insert(EquipoDos entidad);
    }
}
