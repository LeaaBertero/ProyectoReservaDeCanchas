using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    [ApiController]
    [Route("Api/Usuario")]
    public class UsuarioControllers : ControllerBase
    {
        private readonly Context context;

        public UsuarioControllers(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>>Get() 
        {
            return await context.Usuarios.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>>Post(Usuario entidad)
        {
            try
            {
                context.Usuarios.Add(entidad);
                await context.SaveChangesAsync();
                return entidad.Id;
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }
        }
    }
}
