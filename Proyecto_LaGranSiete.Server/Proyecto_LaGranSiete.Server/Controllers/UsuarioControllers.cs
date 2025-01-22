using AutoMapper;
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
        private readonly IUsuarioRepositorio repositorio;
        
        #region Campo context
        private readonly IMapper mapper;
        #endregion

        #region Constructor
        public UsuarioControllers(IUsuarioRepositorio repositorio,
                                  IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }
        #endregion

        #region Get usuario
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return await repositorio.Select();
        }
        #endregion

        #region Get for ID
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Usuario>> Get(int id)
        {
            var lean = await repositorio.SelectById(id);

            if (lean == null)
            {
                return NotFound();
            }
            return lean;


        }
        #endregion

        #region Post Usuario
        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearUsuarioDTO entidadDTO)
        {
            try
            {
                Usuario entidad = mapper.Map<Usuario>(entidadDTO);
                return await repositorio.Insert(entidad);

            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }
        }
        #endregion
    }
}




       



