using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionesDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_EquipoDos_EquipoDosId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_EquipoUno_EquipoUnoId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Equipos_EquipoId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Pagos_PagoId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Partidos_PartidoId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Reservas_ReservaId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Reservas_ReservaId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Usuarios_UsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ReservaId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_UsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_EquipoId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_PagoId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_PartidoId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_ReservaId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "PagoId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "PartidoId",
                table: "Reservas");

            migrationBuilder.AlterColumn<decimal>(
                name: "Monto",
                table: "Reservas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MetodoPago",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoUnoId",
                table: "Reservas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoDosId",
                table: "Reservas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_EquipoDos_EquipoDosId",
                table: "Reservas",
                column: "EquipoDosId",
                principalTable: "EquipoDos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_EquipoUno_EquipoUnoId",
                table: "Reservas",
                column: "EquipoUnoId",
                principalTable: "EquipoUno",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_EquipoDos_EquipoDosId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_EquipoUno_EquipoUnoId",
                table: "Reservas");

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Monto",
                table: "Reservas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<bool>(
                name: "MetodoPago",
                table: "Reservas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoUnoId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EquipoDosId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagoId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartidoId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ReservaId",
                table: "Usuarios",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioId",
                table: "Usuarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EquipoId",
                table: "Reservas",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_PagoId",
                table: "Reservas",
                column: "PagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_PartidoId",
                table: "Reservas",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ReservaId",
                table: "Reservas",
                column: "ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_EquipoDos_EquipoDosId",
                table: "Reservas",
                column: "EquipoDosId",
                principalTable: "EquipoDos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_EquipoUno_EquipoUnoId",
                table: "Reservas",
                column: "EquipoUnoId",
                principalTable: "EquipoUno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Equipos_EquipoId",
                table: "Reservas",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Pagos_PagoId",
                table: "Reservas",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Partidos_PartidoId",
                table: "Reservas",
                column: "PartidoId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Reservas_ReservaId",
                table: "Reservas",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioId",
                table: "Reservas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Reservas_ReservaId",
                table: "Usuarios",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Usuarios_UsuarioId",
                table: "Usuarios",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
