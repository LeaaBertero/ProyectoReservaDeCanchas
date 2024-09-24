using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.Shared.DTO;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    [ApiController]
    [Route("Api/Equipos")]

    public class EquiposControllers : ControllerBase
    {       
        private readonly Context context;
        private readonly IMapper mapper;

        //constructor
        public EquiposControllers(Context Context, 
                                    IMapper mapper)
        {
            context = Context;
            this.mapper = mapper;
        }

        //EndPoint (Get)
        [HttpGet]
        public async Task<ActionResult<List<Equipo>>> Get() //Task == "Tarea"
        {
            return await context.Equipos.ToListAsync();
        }

        //get 1
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Equipo>> Get(int id)
        {
            Equipo? VariableAuxiliar = await context.Equipos
                .FirstOrDefaultAsync(x => x.Id == id);

            if (VariableAuxiliar == null)
            {
                return NotFound();
            }

            return VariableAuxiliar;
        }

        //get 2
        //[HttpGet("GetByCod/{cod}")]
        //public async Task<ActionResult<Equipos>> GetByCod(string cod)
        //{
        //    Equipos? lean = await context.Equipos
        //        .FirstOrDefaultAsync(x => x.NombreEquipos == cod);

        //    if (lean == null)
        //    {
        //        return NotFound();
        //    }

        //    return lean;
        //}




        [HttpGet("Existe/{id:int}")]
        public async Task<ActionResult<bool>> Existe(int id)
        {
            var existe = await context.Equipos.AnyAsync(x => x.Id == id);
            return existe;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearEquiposDTO entidadDTO)
        {
            try
            {
                //----------------------------------------------------------------------------
                //entidad que voy a adicionar a la tabla reservas en el context(Base de dato)
                //Reservas entidad = new Reservas();
                //entidad.FechaHoraReserva = entidadDTO.FechaHoraReserva;
                //entidad.DuracionAlquiler = entidadDTO.DuracionAlquiler;
                //entidad.Monto = entidadDTO.Monto;
                //entidad.MetodoPago = entidadDTO.MetodoPago;
                //entidad.EstadoReserva = entidadDTO.EstadoReserva;

                //Reemplazo de Inyeccion (En una sola linea)
                Equipo entidad = mapper.Map<Equipo>(entidadDTO);

                //---------------------------------------------------------------------------- //Comentar acá despues de hacer la inyección en el context
                context.Equipos.Add(entidad);
                await context.SaveChangesAsync(); //espera y guarda los cambios del context
                return entidad.Id; //Id de la entidad 
            }
            catch (Exception ErrorMessage)
            {
                //InnerException = quiere decir que el error vino por un tercero, en este caso por la base de datos
                return BadRequest(ErrorMessage.Message);
                //throw;
            }
        }

        [HttpPut("{id:int}")] //Api / Equipos
        public async Task<ActionResult> Put(int id, [FromBody] Equipo entidad)
        {
            if (id == entidad.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var Lean = await context.Equipos.Where(e => e.Id == id).FirstOrDefaultAsync();

            if (Lean == null)
            {
                return NotFound("No existe el equipo buscado");
            }

            Lean.NombreEquipos = entidad.NombreEquipos;
            Lean.Integrantes = entidad.Integrantes;
            


            try
            {
                context.Equipos.Update(Lean);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
                //throw;
            }
        }

        //Delete
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {                                            //(expresión en lambda)
            var existe = await context.Equipos.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound($"El equipo buscado {id}, no se encuentra");
            }

            Equipo EntidadBorrar = new Equipo();
            EntidadBorrar.Id = id;

            context.Remove(EntidadBorrar);

            await context.SaveChangesAsync();

            return Ok();
        }

    }
}


