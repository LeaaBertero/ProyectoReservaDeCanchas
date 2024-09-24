using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.Shared.DTO;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    [ApiController]
    [Route("Api/Partidos")]

    public class PartidosControllers : ControllerBase
    {

        private readonly Context context;
        private readonly IMapper mapper;

        //constructor
        public PartidosControllers(Context Context, 
                                    IMapper mapper)
        {
            context = Context;
            this.mapper = mapper;
        }

        //EndPoint (Get)
        [HttpGet]
        public async Task<ActionResult<List<Partido>>> Get() //Task == "Tarea"
        {
            return await context.Partidos.ToListAsync();
        }

        //get 1
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Partido>> Get(int id)
        {
            Partido? VariableAuxiliar = await context.Partidos
                .FirstOrDefaultAsync(x => x.Id == id);

            if (VariableAuxiliar == null)
            {
                return NotFound();
            }

            return VariableAuxiliar;
        }

        //get 2
        //[HttpGet("GetByCod/{cod}")]
        //public async Task<ActionResult<Partidos>> GetByCod(string cod)
        //{
        //    Partidos? lean = await context.Partidos
        //        .FirstOrDefaultAsync(x => x.FechaHoraPartidos = cod);

        //    if (lean == null)
        //    {
        //        return NotFound();
        //    }

        //    return lean;
        //}




        [HttpGet("Existe/{id:int}")]
        public async Task<ActionResult<bool>> Existe(int id)
        {
            var existe = await context.Partidos.AnyAsync(x => x.Id == id);
            return existe;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearPartidosDTO entidadDTO)
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
                Partido entidad = mapper.Map<Partido>(entidadDTO);

                //---------------------------------------------------------------------------- //Comentar acá despues de hacer la inyección en el context
                context.Partidos.Add(entidad);
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

        [HttpPut("{id:int}")] //Api / Reservas
        public async Task<ActionResult> Put(int id, [FromBody] Partido entidad)
        {
            if (id == entidad.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var Lean = await context.Partidos.Where(e => e.Id == id).FirstOrDefaultAsync();

            if (Lean == null)
            {
                return NotFound("No existe el partido reservado");
            }

            //--------- (Propiedades de la tabla) -----------
            Lean.FechaHoraPartidos = entidad.FechaHoraPartidos;
           
            //--------- (Propiedades de la tabla) -----------



            try
            {
                context.Partidos.Update(Lean);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
                //throw;
            }
        }

        //Delete
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {                                            //(expresión en lambda)
            var existe = await context.Partidos.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound($"El partido reservado {id}, no se encuentra");
            }

            Partido EntidadBorrar = new Partido();
            EntidadBorrar.Id = id;

            context.Remove(EntidadBorrar);

            await context.SaveChangesAsync();

            return Ok();
        }

    }
}

