using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.Server.Repositorio;
using Proyecto_LaGranSiete.Shared.DTO;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    [ApiController]
    [Route("Api/Usuario")]

    public class UsuarioControllers : ControllerBase
    {
        #region Campo context
        private readonly Context context;
        #endregion

        #region Constructor
        public UsuarioControllers(Context context)      
        {
            this.context = context;
        }
        #endregion

        #region Get usuario
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return await context.Usuarios.ToListAsync();
        }
        #endregion

        #region Get for ID
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Usuario>> Get(int id)
        {
            var lean = await context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);

            if (lean == null)
            {
                return NotFound();
            }
            return Ok(lean);

            //return lean;
        }
        #endregion

        #region Post Usuario
        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearUsuarioDTO entidadDTO)
        {
            try
            {
                Usuario entidad = new Usuario();

                entidad.Nombre = entidadDTO.Nombre;
                entidad.Apellido = entidadDTO.Apellido;
                entidad.FechaNacimiento = entidadDTO.FechaNacimiento;
                entidad.Telefono = entidadDTO.Telefono?.ToString();
                entidad.CorreoElectronico = entidadDTO.CorreoElectronico;
                entidad.Parentesco = entidadDTO.Parentesco;

                context.Usuarios.Add(entidad);
                await context.SaveChangesAsync();
                return entidad.Id;
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }
        }
        #endregion



        //[HttpPut("{id:int}")]
        //public async Task<ActionResult> Put(int id,[FromBody] Usuario entidad) 
        //{
        //    if (id != entidad.Id)
        //    {
        //        return BadRequest("Datos incorrectos");
        //    }

        //    var lean = await context.Usuarios.Where(e=> entidad.Id==id).FirstOrDefaultAsync();

        //    if (lean == null)
        //    {
        //        return NotFound("No existe el usuario buscado");
        //    }

        //    lean.Nombre = entidad.Nombre;
        //    lean.Apellido = entidad.Apellido;
        //    lean.FechaNacimiento = entidad.FechaNacimiento;
        //    lean.Telefono = entidad.Telefono;
        //    lean.CorreoElectronico = entidad.CorreoElectronico;
        //    lean.Parentesco = entidad.Parentesco;

        //    try
        //    {
        //        context.Usuarios.Update(lean);
        //        await context.SaveChangesAsync();
        //    }
        //    catch (Exception err)
        //    {

        //        return BadRequest(err.Message);
        //    }


        //    return Ok();
        //}

        //[HttpDelete("{id:int}")]
        //public async Task<ActionResult> Delete(int id) 
        //{
        //    var existe = await context.Usuarios.AnyAsync(x =>x.Id == id);

        //    if (!existe)
        //    {
        //        return NotFound($"El usuario {id} que se intenta borrar, no existe.");
        //    }

        //    Usuario entidadBorrar = new Usuario();
        //    entidadBorrar.Id = id;  

        //    context.Remove(entidadBorrar);
        //    await context.SaveChangesAsync();
        //    return Ok();

        //}
    }
}



