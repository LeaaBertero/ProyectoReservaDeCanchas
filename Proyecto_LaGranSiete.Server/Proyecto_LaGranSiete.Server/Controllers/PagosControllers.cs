using Microsoft.AspNetCore.Mvc; //Model View Controller
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.BD.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Proyecto_LaGranSiete.Shared.DTO;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    [ApiController]
    [Route("Api/Pagos")] //Ruta de controllers
    
    public class PagosControllers : ControllerBase
    {
        private readonly Context context;
        private readonly IMapper mapper;

        public PagosControllers(Context Context, 
                                IMapper mapper)
        {
            context = Context;
            this.mapper = mapper;
        }

        //EndPoint (Get)
        [HttpGet]
        public async Task<ActionResult<List<Pago>>> Get() //Task == "Tarea"
        {
            return await context.Pagos.ToListAsync();
        }

        //get 1
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Pago>> Get(int id)
        {
            Pago? VariableAuxiliar = await context.Pagos
                .FirstOrDefaultAsync(x => x.Id == id);

            if (VariableAuxiliar == null)
            {
                return NotFound();
            }

            return VariableAuxiliar;
        }

        //get 2
        //[HttpGet("GetByCod/{cod}")]
        //public async Task<ActionResult<Pagos>> GetByCod(string cod)
        //{
        //    Pagos? lean = await context.Pagos
        //        .FirstOrDefaultAsync(x => x.MetodoPago == cod);

        //    if (lean == null)
        //    {
        //        return NotFound();
        //    }

        //    return lean;
        //}




        [HttpGet("Existe/{id:int}")]
        public async Task<ActionResult<bool>> Existe(int id)
        {
            var existe = await context.Pagos.AnyAsync(x => x.Id == id);
            return existe;
        }

        //cambiar cuando haga el DTO de la tabla Pagos
        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearPagosDTO entidadDTO)
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
                Pago entidad = mapper.Map<Pago>(entidadDTO);

                //---------------------------------------------------------------------------- //Comentar acá despues de hacer la inyección en el context
                context.Pagos.Add(entidad);
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

        [HttpPut("{id:int}")] //Api / Pagos
        public async Task<ActionResult> Put(int id, [FromBody] Pago entidad)
        {
            if (id == entidad.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var Lean = await context.Pagos.Where(e => e.Id == id).FirstOrDefaultAsync();

            if (Lean == null)
            {
                return NotFound("El pago buscado, no se encuentra");
            }


            Lean.Monto = entidad.Monto;
            Lean.FechaPago = entidad.FechaPago;
            
            


            try
            {
                context.Pagos.Update(Lean);
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
            var existe = await context.Pagos.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound($"El pago buscado {id}, no se encuentra");
            }

            Pago EntidadBorrar = new Pago();
            EntidadBorrar.Id = id;

            context.Remove(EntidadBorrar);

            await context.SaveChangesAsync();

            return Ok();
        }
    }
}


