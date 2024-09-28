using Microsoft.AspNetCore.Http.HttpResults;
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
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return await context.Usuarios.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Usuario entidad)
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

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id,[FromBody] Usuario entidad) 
        {
            if (id != entidad.Id)
            {
                return BadRequest("Datos incorrectos");
            }
             
            var lean = await context.Usuarios.Where(e=> entidad.Id==id).FirstOrDefaultAsync();

            if (lean == null)
            {
                return NotFound("No existe el usuario buscado");
            }

            lean.Nombre = entidad.Nombre;
            lean.Apellido = entidad.Apellido;
            lean.FechaNacimiento = entidad.FechaNacimiento;
            lean.Telefono = entidad.Telefono;
            lean.CorreoElectronico = entidad.CorreoElectronico;
            lean.Parentesco = entidad.Parentesco;

            try
            {
                context.Usuarios.Update(lean);
                await context.SaveChangesAsync();
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }


            return Ok();
        }

    }

}
