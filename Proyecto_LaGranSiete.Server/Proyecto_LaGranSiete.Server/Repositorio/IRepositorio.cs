using Proyecto_LaGranSiete.BD.Data;

namespace Proyecto_LaGranSiete.Server.Repositorio
{
    public interface IRepositorio<E> where E : class, IEntityBase
    {
        Task<int> Insert(E entidad);
        Task<List<E>> Select();
        Task<E> SelectById(int id);
        Task<bool> Existe(int id);
        Task<bool> Update(int id, E entidad);
        Task<bool> Borrar(int id);
    }
}