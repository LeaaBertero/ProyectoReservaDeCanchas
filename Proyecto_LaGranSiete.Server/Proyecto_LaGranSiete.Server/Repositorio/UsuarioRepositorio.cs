using Microsoft.AspNetCore.Mvc;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;

namespace Proyecto_LaGranSiete.Server.Repositorio
{
    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        //constructor de la interfáz de la clase (Repositorio)
        //que tiene como base , la herencia del context (Base de datos)
        public UsuarioRepositorio(Context Context) : base(Context)
        {

        }

        public Task<ActionResult<int>> Insert(EquipoUno entidad)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<int>> Insert(EquipoDos entidad)
        {
            throw new NotImplementedException();
        }
    }
}
