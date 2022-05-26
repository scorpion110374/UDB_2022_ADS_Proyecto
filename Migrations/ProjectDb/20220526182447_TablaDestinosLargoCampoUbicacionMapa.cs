using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Vesa.Migrations.ProjectDb
{
    public partial class TablaDestinosLargoCampoUbicacionMapa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DireccionMapa",
                table: "Destinos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DireccionMapa",
                table: "Destinos",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
