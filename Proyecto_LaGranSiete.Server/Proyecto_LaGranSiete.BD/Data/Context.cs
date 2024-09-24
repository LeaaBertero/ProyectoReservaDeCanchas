using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Proyecto_LaGranSiete.BD.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaGranSiete.BD.Data
{
    //context, que hereda de DbContext
    public class Context : DbContext
    {
        //constructor del Context (Base de datos)
        public Context(DbContextOptions options) : base(options)
        {
            //para realizar este constructor hacer control punto + (.) y elegir "Generar contructor con options"
        }
        
        //-------------------------------------------
        //Tablas o entidades de la base de datos

        //Nota importante: Las entidades van en singular y la propiead en plural
        public DbSet<Cancha> Canchas { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<EquipoDos> EquipoDos { get; set; }
        public DbSet<EquipoUno> EquipoUno { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }





        //-------------------------------------------



        //codigo que evita que un registro de la base de datos, pueda borrarse en cascada
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Éste codigo sirve para evitar que se borren los datos en cascada en la base de datos
            var cascadeFKs = modelBuilder.Model.G­etEntityTypes()
                                            .SelectMany(t => t.GetForeignKeys())
                                            .Where(fk => !fk.IsOwnership
                                                        && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {        //Elimina el cmportamiento               
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}



        
