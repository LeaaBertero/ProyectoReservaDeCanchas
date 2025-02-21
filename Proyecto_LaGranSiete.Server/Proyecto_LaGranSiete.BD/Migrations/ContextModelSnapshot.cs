﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_LaGranSiete.BD.Data;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Cancha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CanchasId")
                        .HasColumnType("int");

                    b.Property<int>("Disponibilidad")
                        .HasColumnType("int");

                    b.Property<string>("NombreCancha")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservaId");

                    b.HasIndex(new[] { "NombreCancha", "Disponibilidad" }, "Cancha_NombreCancha_Disponibilidad");

                    b.HasIndex(new[] { "CanchasId" }, "CanchasId")
                        .IsUnique();

                    b.ToTable("Canchas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("Integrantes")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartidoId");

                    b.HasIndex(new[] { "EquipoId" }, "EquipoId")
                        .IsUnique();

                    b.HasIndex(new[] { "NombreEquipos", "Integrantes" }, "Equipo_NombreEquipos_Integrantes");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoDos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoDosId")
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipoDos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartidoId");

                    b.HasIndex(new[] { "EquipoDosId" }, "EquipoDosId")
                        .IsUnique();

                    b.HasIndex(new[] { "NombreEquipoDos" }, "EquipoDos_NombreEquipoDos");

                    b.ToTable("EquipoDos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoUno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoUnoId")
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipoUno")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartidoId");

                    b.HasIndex(new[] { "EquipoUnoId" }, "EquipoUnoId")
                        .IsUnique();

                    b.HasIndex(new[] { "NombreEquipoUno" }, "EquipoUno_NombreEquipoUno");

                    b.ToTable("EquipoUno");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CanchaId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoDosId")
                        .HasColumnType("int");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoUnoId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaPago")
                        .HasColumnType("date");

                    b.Property<string>("MetodoPagado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Monto")
                        .HasColumnType("real");

                    b.Property<float>("Monto_Pago")
                        .HasMaxLength(10)
                        .HasColumnType("real");

                    b.Property<int>("PagoId")
                        .HasColumnType("int");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaHora")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CanchaId");

                    b.HasIndex("EquipoDosId");

                    b.HasIndex("EquipoId");

                    b.HasIndex("EquipoUnoId");

                    b.HasIndex("PartidoId");

                    b.HasIndex(new[] { "PagoId" }, "PagoId")
                        .IsUnique();

                    b.HasIndex(new[] { "Monto_Pago", "FechaPago" }, "Pago_Monto_Pago_FechaPago");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CanchaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHoraPartidos")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CanchaId");

                    b.HasIndex(new[] { "FechaHoraPartidos" }, "Partido_FechaHoraPartidos");

                    b.HasIndex(new[] { "PartidoId" }, "PartidosId")
                        .IsUnique();

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DuracionAlquiler")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoDosId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoUnoId")
                        .HasColumnType("int");

                    b.Property<string>("EstadoReserva")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FechaHoraReserva")
                        .HasColumnType("datetime2");

                    b.Property<string>("MetodoPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Monto")
                        .HasColumnType("real");

                    b.Property<int?>("ReservaId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoDosId");

                    b.HasIndex("EquipoUnoId");

                    b.HasIndex("ReservaId");

                    b.HasIndex(new[] { "FechaHoraReserva", "DuracionAlquiler", "Monto", "MetodoPago", "EstadoReserva" }, "FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva");

                    b.HasIndex(new[] { "UsuarioId" }, "UsuarioId_UQ")
                        .IsUnique()
                        .HasFilter("[UsuarioId] IS NOT NULL");

                    b.ToTable("Reservas");

                    b.HasAnnotation("Relational:JsonPropertyName", "reservas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Cancha", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Equipo", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Partido", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoDos", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Partido", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoUno", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Partido", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Pago", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Cancha", "Canchas")
                        .WithMany()
                        .HasForeignKey("CanchaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.EquipoDos", null)
                        .WithMany("Pagos")
                        .HasForeignKey("EquipoDosId");

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Equipo", "Equipos")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.EquipoUno", null)
                        .WithMany("Pagos")
                        .HasForeignKey("EquipoUnoId");

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Partido", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Canchas");

                    b.Navigation("Equipos");

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Partido", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Cancha", "Canchas")
                        .WithMany()
                        .HasForeignKey("CanchaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Canchas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.EquipoDos", null)
                        .WithMany("Reservas")
                        .HasForeignKey("EquipoDosId");

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.EquipoUno", null)
                        .WithMany("Reservas")
                        .HasForeignKey("EquipoUnoId");

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", null)
                        .WithMany("Reservas")
                        .HasForeignKey("ReservaId");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Usuario", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Usuario", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoDos", b =>
                {
                    b.Navigation("Pagos");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoUno", b =>
                {
                    b.Navigation("Pagos");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Usuario", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
