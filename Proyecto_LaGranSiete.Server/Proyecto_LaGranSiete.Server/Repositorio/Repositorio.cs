using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_LaGranSiete.BD.Data;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.Shared.DTO;

namespace Proyecto_LaGranSiete.Server.Repositorio
{
    //Repositorio_ es una clase especializada en hacer un CRUD sobre una tabla cualquiera de la base de datos
    //<E> => (Entidad)
    public class Repositorio<E> : IRepositorio<E> where E : class, IEntityBase

    {
        //crud del repositorio
        //Método privado (de solo lectura)
        private readonly Context context;

        //Constructor de la clase Repositorio
        //posteriormente hacer (Control + .) en context, y elegir la opcion Crer y asignar campo Context
       
        #region constructor
        public Repositorio(Context Context)
        {
            context = Context;
        }
        #endregion

        #region Select
        public async Task<List<E>> Select() //Task == "Tarea"
        {
            return await context.Set<E>().ToListAsync();
        }
        #endregion

        #region Insert
        public async Task<int> Insert(E entidad)
        {
            try
            {


                await context.Set<E>().AddAsync(entidad);
                await context.SaveChangesAsync(); //espera y guarda los cambios del context
                return entidad.Id; //Id de la entidad 
            }
            catch (Exception Err)
            {
                //return BadRequest(ErrorMessage.Message);
                throw Err;
            }
        }
        #endregion

        #region Update
        public async Task<bool> Update(int id, E entidad)
        {
            if (id == entidad.Id)
            {
                return false;
            }

            //---------------------------------------
            // este codigo de aca arriba
            //---------------------------------------
            var Lean = await SelectById(id);

            //var Lean = await context.Set<E>()
            //                .Where(e => e.Id == id)
            //                .FirstOrDefaultAsync();

            //---------------------------------------
            // este codigo de acá abajo, son exactamente lo mismo
            //---------------------------------------

            if (Lean == null)
            {
                return false;
            }

            //Lean.Nombre = entidad.Nombre;
            //Lean.Apellido = entidad.Apellido;
            //Lean.FechaNacimiento = entidad.FechaNacimiento;
            //Lean.Telefono = entidad.Telefono;
            //Lean.CorreoElectronico = entidad.CorreoElectronico;
            //Lean.Parentesco = entidad.Parentesco;

            try
            {
                context.Set<E>().Update(entidad);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                //return BadRequest(e.Message);
                throw e;
            }
        }
        #endregion

        #region SelectById
        public async Task<E> SelectById(int id)
        {
            E? lean = await context.Set<E>().AsNoTracking() // AsNoTracking() == (Para evitar que no quede en memoria)
                .FirstOrDefaultAsync(x => x.Id == id);

            return lean;
        }

        public async Task<bool> Borrar(int id)
        {                                            //(expresión en lambda)
            var lean = await SelectById(id);

            if (lean == null)
            {
                return false;
            }

            context.Set<E>().Remove(lean);
            await context.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Existe
        public async Task<bool> Existe(int id)
        {
            var existe = await context.Set<E>().AnyAsync(x => x.Id == id);
            return existe;
        }
        #endregion
    }
}
          


