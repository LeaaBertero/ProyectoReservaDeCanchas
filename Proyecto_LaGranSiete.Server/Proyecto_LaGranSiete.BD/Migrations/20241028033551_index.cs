using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class index : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Canchas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanchasId = table.Column<int>(type: "int", nullable: false),
                    NombreCancha = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Disponibilidad = table.Column<int>(type: "int", nullable: false),
                    ReservaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canchas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartidoId = table.Column<int>(type: "int", nullable: false),
                    FechaHoraPartidos = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CanchaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partidos_Canchas_CanchaId",
                        column: x => x.CanchaId,
                        principalTable: "Canchas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipoDos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipoDosId = table.Column<int>(type: "int", nullable: false),
                    NombreEquipoDos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoDos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipoDos_Partidos_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipoId = table.Column<int>(type: "int", nullable: false),
                    NombreEquipos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Integrantes = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_Partidos_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipoUno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipoUnoId = table.Column<int>(type: "int", nullable: false),
                    NombreEquipoUno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoUno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipoUno_Partidos_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PagoId = table.Column<int>(type: "int", nullable: false),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto_Pago = table.Column<float>(type: "real", maxLength: 10, nullable: false),
                    MetodoPagado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaPago = table.Column<DateOnly>(type: "date", nullable: false),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: false),
                    CanchaId = table.Column<int>(type: "int", nullable: false),
                    EquipoDosId = table.Column<int>(type: "int", nullable: true),
                    EquipoUnoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagos_Canchas_CanchaId",
                        column: x => x.CanchaId,
                        principalTable: "Canchas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagos_EquipoDos_EquipoDosId",
                        column: x => x.EquipoDosId,
                        principalTable: "EquipoDos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pagos_EquipoUno_EquipoUnoId",
                        column: x => x.EquipoUnoId,
                        principalTable: "EquipoUno",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pagos_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagos_Partidos_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservaId = table.Column<int>(type: "int", nullable: true),
                    FechaHoraReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuracionAlquiler = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MetodoPago = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EstadoReserva = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    EquipoDosId = table.Column<int>(type: "int", nullable: true),
                    EquipoUnoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_EquipoDos_EquipoDosId",
                        column: x => x.EquipoDosId,
                        principalTable: "EquipoDos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservas_EquipoUno_EquipoUnoId",
                        column: x => x.EquipoUnoId,
                        principalTable: "EquipoUno",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservas_Reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "Reservas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "Cancha_NombreCancha_Disponibilidad",
                table: "Canchas",
                columns: new[] { "NombreCancha", "Disponibilidad" });

            migrationBuilder.CreateIndex(
                name: "CanchasId",
                table: "Canchas",
                column: "CanchasId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Canchas_ReservaId",
                table: "Canchas",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "EquipoDos_NombreEquipoDos",
                table: "EquipoDos",
                column: "NombreEquipoDos");

            migrationBuilder.CreateIndex(
                name: "EquipoDosId",
                table: "EquipoDos",
                column: "EquipoDosId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EquipoDos_PartidoId",
                table: "EquipoDos",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "Equipo_NombreEquipos_Integrantes",
                table: "Equipos",
                columns: new[] { "NombreEquipos", "Integrantes" });

            migrationBuilder.CreateIndex(
                name: "EquipoId",
                table: "Equipos",
                column: "EquipoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_PartidoId",
                table: "Equipos",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "EquipoUno_NombreEquipoUno",
                table: "EquipoUno",
                column: "NombreEquipoUno");

            migrationBuilder.CreateIndex(
                name: "EquipoUnoId",
                table: "EquipoUno",
                column: "EquipoUnoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EquipoUno_PartidoId",
                table: "EquipoUno",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_CanchaId",
                table: "Pagos",
                column: "CanchaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_EquipoDosId",
                table: "Pagos",
                column: "EquipoDosId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_EquipoId",
                table: "Pagos",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_EquipoUnoId",
                table: "Pagos",
                column: "EquipoUnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_PartidoId",
                table: "Pagos",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "Pago_Monto_Pago_FechaPago",
                table: "Pagos",
                columns: new[] { "Monto_Pago", "FechaPago" });

            migrationBuilder.CreateIndex(
                name: "PagoId",
                table: "Pagos",
                column: "PagoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_CanchaId",
                table: "Partidos",
                column: "CanchaId");

            migrationBuilder.CreateIndex(
                name: "Partido_FechaHoraPartidos",
                table: "Partidos",
                column: "FechaHoraPartidos");

            migrationBuilder.CreateIndex(
                name: "PartidosId",
                table: "Partidos",
                column: "PartidoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EquipoDosId",
                table: "Reservas",
                column: "EquipoDosId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EquipoUnoId",
                table: "Reservas",
                column: "EquipoUnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ReservaId",
                table: "Reservas",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva",
                table: "Reservas",
                columns: new[] { "FechaHoraReserva", "DuracionAlquiler", "Monto", "MetodoPago", "EstadoReserva" });

            migrationBuilder.CreateIndex(
                name: "UsuarioId_UQ",
                table: "Reservas",
                column: "UsuarioId",
                unique: true,
                filter: "[UsuarioId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Canchas_Reservas_ReservaId",
                table: "Canchas",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canchas_Reservas_ReservaId",
                table: "Canchas");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "EquipoDos");

            migrationBuilder.DropTable(
                name: "EquipoUno");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Canchas");
        }
    }
}
