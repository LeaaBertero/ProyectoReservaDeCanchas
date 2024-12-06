using AutoMapper;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.Shared.DTO;
//profile <- "es una clase de AutoMapper"

namespace Proyecto_LaGranSiete.Server.Util
{
    //class AutoMapperProfiles (HEREDA DE) -- Profile, con su respectivo constructor
    public class AutoMapperProfiles : Profile
    {
        //constructor AutoMapper
        protected AutoMapperProfiles()
        {
            //Data Transfer Objetct (Objeto de transferencia de datos)
            CreateMap<CrearEquipoUnoDTO, EquipoUno>();
            CreateMap<EquipoUno, CrearEquipoUnoDTO>();

            CreateMap<CrearEquipoDosDTO, EquipoDos>();
            CreateMap<EquipoDos, CrearEquipoDosDTO>();


            CreateMap<CrearCanchasDTO, Cancha>();
            CreateMap<Cancha, CrearCanchasDTO>();


            CreateMap<CrearEquiposDTO, Equipo>();
            CreateMap<Equipo, CrearEquiposDTO>();


            CreateMap<CrearPagosDTO, Pago>();
            CreateMap<Pago, CrearPagosDTO>();


            CreateMap<CrearPartidosDTO, Partido>();
            CreateMap<Partido, CrearPartidosDTO>();


            CreateMap<CrearReservaDTO, Reserva>();
            CreateMap<Reserva, CrearReservaDTO>();


            CreateMap<CrearUsuariosDTO, Usuario>();
            CreateMap<Usuario, CrearUsuariosDTO>();
        }
    }
}
