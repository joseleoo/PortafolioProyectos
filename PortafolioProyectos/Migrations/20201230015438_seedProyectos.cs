using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortafolioProyectos.Migrations
{
    public partial class seedProyectos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "EN NEGOCIACION" },
                    { 2, "EN PROCESO" },
                    { 3, "TERMINADO" },
                    { 4, "aNULADO" }
                });

            migrationBuilder.InsertData(
                table: "Proyectos",
                columns: new[] { "Id", "ClienteId", "Descripcion", "EstadoId", "FechaFin", "FechaInicio", "Horas", "Precio" },
                values: new object[] { 1, 1, "Leon Software", 1, new DateTime(2021, 1, 18, 20, 54, 37, 341, DateTimeKind.Local).AddTicks(8351), new DateTime(2020, 12, 29, 20, 54, 37, 339, DateTimeKind.Local).AddTicks(9480), 40, 200000.0 });

            migrationBuilder.InsertData(
                table: "Proyectos",
                columns: new[] { "Id", "ClienteId", "Descripcion", "EstadoId", "FechaFin", "FechaInicio", "Horas", "Precio" },
                values: new object[] { 2, 2, "Riesgos", 2, new DateTime(2021, 1, 8, 20, 54, 37, 342, DateTimeKind.Local).AddTicks(2153), new DateTime(2020, 12, 29, 20, 54, 37, 342, DateTimeKind.Local).AddTicks(2120), 35, 205000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
