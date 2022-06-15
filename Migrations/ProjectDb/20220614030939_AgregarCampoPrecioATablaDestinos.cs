using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Vesa.Migrations.ProjectDb
{
    public partial class AgregarCampoPrecioATablaDestinos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Destinos",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DireccionMapa", "Precio" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d15495.269403943099!2d-89.6294444!3d13.84999975!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f62c16156d6e997%3A0x2fd88a9ab0dbc675!2sVolc%C3%A1n%20de%20Santa%20Ana!5e0!3m2!1ses-419!2ssv!4v1653589254629!5m2!1ses-419!2ssv", 50m });

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DireccionMapa", "Precio" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d18907.988373693042!2d-89.63263819999999!3d13.81365735!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f62c6ae5d0724cd%3A0x575417b5f2cc024b!2sVolcan%20de%20Izalco!5e1!3m2!1ses-419!2ssv!4v1653590216152!5m2!1ses-419!2ssv", 50m });

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DireccionMapa", "Precio" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d18933.772221654366!2d-89.3813889!3d13.49222195!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f7cd59f22c8da2b%3A0xc9cb9224ff2461d7!2sPlaya%20El%20Tunco!5e1!3m2!1ses-419!2ssv!4v1653590300412!5m2!1ses-419!2ssv", 50m });

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DireccionMapa", "Precio" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d37807.92262660518!2d-89.54761955!3d13.86320075!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f62dcd48bbf3581%3A0xcbb51df50ff589a9!2sLago%20de%20Coatepeque!5e1!3m2!1ses-419!2ssv!4v1653590348500!5m2!1ses-419!2ssv", 50m });

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DireccionMapa", "Precio" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7748.5909908063095!2d-89.3599041!3d13.8212866!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f63212ab199a6dd%3A0x51207fe999d8c593!2sJoya%20de%20Ceren!5e0!3m2!1ses-419!2ssv!4v1653590378443!5m2!1ses-419!2ssv", 50m });

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DireccionMapa", "Precio" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d15458.673462276234!2d-89.12600760000001!3d14.388589600000001!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f63a22e2515544b%3A0x29d828ff57aed1dd!2sCerro%20El%20Pital!5e0!3m2!1ses-419!2ssv!4v1653590419048!5m2!1ses-419!2ssv", 50m });

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DireccionMapa", "Precio" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d15505.305056993278!2d-89.1943073!3d13.69867895!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8f6330ebffdbfb45%3A0x513c506801a25f0e!2sCentro%20Hist%C3%B3rico%20de%20SS%2C%20San%20Salvador!5e0!3m2!1ses-419!2ssv!4v1653590454327!5m2!1ses-419!2ssv", 50m });

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DireccionMapa", "Precio" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3871.624372032057!2d-89.6795008!3d13.9809501!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x7495b8397db2b9bf!2sSitio%20Arqueol%C3%B3gico%20El%20Tazumal!5e0!3m2!1ses-419!2ssv!4v1653590488480!5m2!1ses-419!2ssv", 50m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Destinos");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DireccionMapa",
                value: "https://goo.gl/maps/xEGnkGYF5ZTda7tT6");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DireccionMapa",
                value: "https://goo.gl/maps/468yqtL2X71zRx3x6");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DireccionMapa",
                value: "https://goo.gl/maps/K4oTe4E7pfuCuXov9");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DireccionMapa",
                value: "https://goo.gl/maps/Mj36THpugjE6qmeu8");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DireccionMapa",
                value: "https://www.google.com/maps/place/Joya+de+Ceren/@13.821297,-89.3642815,16z/data=!3m1!4b1!4m5!3m4!1s0x8f63212ab199a6dd:0x51207fe999d8c593!8m2!3d13.8222445!4d-89.3594449");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DireccionMapa",
                value: "https://goo.gl/maps/3mWWyFfZAYUPvPQs7");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DireccionMapa",
                value: "https://goo.gl/maps/nemAfyZviVMduG9Y7");

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DireccionMapa",
                value: "https://goo.gl/maps/icgJCvJyobD286ka8");
        }
    }
}
