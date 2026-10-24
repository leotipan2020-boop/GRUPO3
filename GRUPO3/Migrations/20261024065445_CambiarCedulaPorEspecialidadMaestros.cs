using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GRUPO3.Migrations
{
    /// <inheritdoc />
    public partial class CambiarCedulaPorEspecialidadMaestros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CedulaIdentidad",
                table: "Maestros",
                newName: "Especialidad");

            migrationBuilder.AlterColumn<string>(
                name: "Especialidad",
                table: "Maestros",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Especialidad",
                table: "Maestros",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.RenameColumn(
                name: "Especialidad",
                table: "Maestros",
                newName: "CedulaIdentidad");
        }
    }
}