using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;

namespace Proyecto_LaGranSiete.Server.Repositorio
{
    public class ReservaRepositorio : Repositorio<Reserva>, IReservaRepositorio
    {
        private readonly Context context;

        //constructor de ReservaRepositorio
        public ReservaRepositorio(Context Context) : base(Context)
        {
           this.context = Context;
        }
    }
}
