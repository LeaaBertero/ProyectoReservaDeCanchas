using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.Shared.DTO;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    //[ApiController]
    //[Route("Api/Canchas")]

    //public class CanchasControllers : ControllerBase
    //{
    //    private readonly Context context;
    //    private readonly IMapper mapper;

    //    //constructor
    //    public CanchasControllers(Context Context, 
    //                                IMapper mapper)
    //    {
    //        context = Context;
    //        this.mapper = mapper;
    //    }

    //    //EndPoint (Get)
    //    [HttpGet]
    //    public async Task<ActionResult<List<Cancha>>> Get() //Task == "Tarea"
    //    {
    //        return await context.Canchas.ToListAsync();
    //    }

    //    //get 1
    //    [HttpGet("{id:int}")]
    //    public async Task<ActionResult<Cancha>> Get(int id)
    //    {
    //        Cancha? VariableAuxiliar = await context.Canchas
    //            .FirstOrDefaultAsync(x => x.Id == id);

    //        if (VariableAuxiliar == null)
    //        {
    //            return NotFound();
    //        }

    //        return VariableAuxiliar;
    //    }

    //    //get 2
    //    //[HttpGet("GetByCod/{cod}")]
    //    //public async Task<ActionResult<Canchas>> GetByCod(string cod)
    //    //{
    //    //    Canchas? lean = await context.Canchas
    //    //        .FirstOrDefaultAsync(x => x.NombreCancha == cod);

    //    //    if (lean == null)
    //    //    {
    //    //        return NotFound();
    //    //    }

    //    //    return lean;
    //    //}




    //    [HttpGet("Existe/{id:int}")]
    //    public async Task<ActionResult<bool>> Existe(int id)
    //    {
    //        var existe = await context.Canchas.AnyAsync(x => x.Id == id);
    //        return existe;
    //    }


    //    [HttpPost]
    //    public async Task<ActionResult<int>> Post(CrearCanchasDTO entidadDTO)
    //    {
    //        try
    //        {
    //            //----------------------------------------------------------------------------
    //            //entidad que voy a adicionar a la tabla reservas en el context(Base de dato)
    //            //Reservas entidad = new Reservas();
    //            //entidad.FechaHoraReserva = entidadDTO.FechaHoraReserva;
    //            //entidad.DuracionAlquiler = entidadDTO.DuracionAlquiler;
    //            //entidad.Monto = entidadDTO.Monto;
    //            //entidad.MetodoPago = entidadDTO.MetodoPago;
    //            //entidad.EstadoReserva = entidadDTO.EstadoReserva;

    //            //Reemplazo de Inyeccion (En una sola linea)
    //            Cancha entidad = mapper.Map<Cancha>(entidadDTO);

    //            //---------------------------------------------------------------------------- //Comentar acá despues de hacer la inyección en el context
    //            context.Canchas.Add(entidad);
    //            await context.SaveChangesAsync(); //espera y guarda los cambios del context
    //            return entidad.Id; //Id de la entidad 
    //        }
    //        catch (Exception ErrorMessage)
    //        {
    //            //InnerException = quiere decir que el error vino por un tercero, en este caso por la base de datos
    //            return BadRequest(ErrorMessage.Message);
    //            //throw;
    //        }
    //    }

    //    [HttpPut("{id:int}")] //Api / Equipos
    //    public async Task<ActionResult> Put(int id, [FromBody] Cancha entidad)
    //    {
    //        if (id == entidad.Id)
    //        {
    //            return BadRequest("Datos incorrectos");
    //        }

    //        var Lean = await context.Canchas.Where(e => e.Id == id).FirstOrDefaultAsync();

    //        if (Lean == null)
    //        {
    //            return NotFound("No existe la reserva de la cancha");
    //        }

    //        //-------- (Formato sugerido por entity) -----------
    //        //Lean.NombreCancha = entidad.;
    //        Lean.NombreCancha = entidad.NombreCancha;
    //        Lean.Disponibilidad = entidad.Disponibilidad;
    //        //-------- (Formato sugerido por entity) -----------





    //        try
    //        {
    //            context.Canchas.Update(Lean);
    //            await context.SaveChangesAsync();
    //            return Ok();
    //        }
    //        catch (Exception e)
    //        {

    //            return BadRequest(e.Message);
    //            //throw;
    //        }
    //    }

    //    //Delete
    //    [HttpDelete("{id:int}")]
    //    public async Task<ActionResult> Delete(int id)
    //    {                                            //(expresión en lambda)
    //        var existe = await context.Canchas.AnyAsync(x => x.Id == id);

    //        if (!existe)
    //        {
    //            return NotFound($"La reserva de la cancha {id}, no se encuentra");
    //        }

    //        Cancha EntidadBorrar = new Cancha();
    //        EntidadBorrar.Id = id;

    //        context.Remove(EntidadBorrar);

    //        await context.SaveChangesAsync();

    //        return Ok();
    //    }

    //}

}

