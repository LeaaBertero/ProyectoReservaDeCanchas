using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.Server.Repositorio;
using Proyecto_LaGranSiete.Shared.DTO;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    [ApiController]
    [Route("Api/Reservas")] //Ruta de controllers

    public class ReservasControllers : ControllerBase
    {
       
        private readonly IReservaRepositorio repositorio;

        public ReservasControllers(IReservaRepositorio repositorio)
        {
            //this.context = context;
            this.repositorio = repositorio;
        }

        //private readonly IMapper mapper;

        //constructor
       

        //EndPoint (Get)
        [HttpGet]
        public async Task<ActionResult<List<Reserva>>> Get() //Task == "Tarea"
        {
            return await repositorio.Select();
        }

        ////get 1
        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<Reserva>> Get(int id)
        //{
        //    Reserva? VariableAuxiliar = await repositorio.SelectById(id);

        //    if (VariableAuxiliar == null)
        //    {
        //        return NotFound();
        //    }

        //    return VariableAuxiliar;
        //}

        //get 2
        //[HttpGet("GetByCod/{cod}")]
        //public async Task<ActionResult<Reservas>> GetByCod(string cod)
        //{
        //    Reservas? lean = await Context.Reservas
        //        .FirstOrDefaultAsync(x => x.EstadoReserva == cod);

        //    if (lean == null)
        //    {
        //        return NotFound();
        //    }

        //    return lean;
        //}




        [HttpGet("Existe/{id:int}")]
        public async Task<ActionResult<bool>> Existe(int id)
        {
            return await repositorio.Existe(id);
        }



        [HttpPost]
        public async Task<ActionResult<int>> Post(Reserva entidad)
        {
            try
            {
                return await repositorio.Insert(entidad);
            }
            catch (Exception ErrorMessage)
            {
                //InnerException = quiere decir que el error vino por un tercero, en este caso por la base de datos
                return BadRequest(ErrorMessage.Message);
                //throw;
            }
        }




        [HttpPut("{id:int}")] //Api / Reservas
        public async Task<ActionResult> Put(int id, [FromBody] Reserva entidad)
        {
            if (id == entidad.Id)
            {
                return BadRequest("Datos incorrectos");
            }


            try
            {
                if (id != entidad.Id)
                {
                    return BadRequest("Datos incorrectos");
                }

                var Lean = await repositorio.Update(id, entidad);

                if (!Lean)
                {
                    return BadRequest("No se pudo actualizar la reserva");
                }

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
        {
            var resp = await repositorio.Borrar(id);

            if (!resp)
            {
                return BadRequest("No se pudo eliminar la reserva");
            }


            return Ok();
        }

    }
}
