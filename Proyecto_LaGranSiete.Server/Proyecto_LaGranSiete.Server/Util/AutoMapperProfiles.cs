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
        public AutoMapperProfiles()
        {

            //Data Transfer Objetct (Objeto de transferencia de datos)


            CreateMap<CrearUsuarioDTO, Usuario>();
            CreateMap<Usuario, CrearUsuarioDTO>();

            CreateMap<CrearReservaDTO, Reserva>();
            CreateMap<Reserva, CrearReservaDTO>();

            CreateMap<CrearPartidoDTO, Partido>();
            CreateMap<Partido, CrearPartidoDTO>();

            CreateMap<CrearPagoDTO, Pago>();
            CreateMap<Pago, CrearPagoDTO>();

            CreateMap<CrearEquiposDTO, Equipo>();
            CreateMap<Equipo, CrearEquiposDTO>();


            CreateMap<CrearCanchaDTO, Cancha>();
            CreateMap<Cancha, CrearCanchaDTO>();


            CreateMap<CrearEquipoDosDTO, EquipoDos>();
            CreateMap<EquipoDos, CrearEquipoDosDTO>();

            CreateMap<CrearEquipoUnoDTO, EquipoUno>();
            CreateMap<EquipoUno, CrearEquipoUnoDTO>();


        }
    }
}
