using Microsoft.EntityFrameworkCore.Migrations;

namespace PortafolioProyectos.Migrations
{
    public partial class proyecto4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LenguajeId",
                table: "Proyectos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProyectoId",
                table: "Lenguajes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_LenguajeId",
                table: "Proyectos",
                column: "LenguajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lenguajes_ProyectoId",
                table: "Lenguajes",
                column: "ProyectoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lenguajes_Proyectos_ProyectoId",
                table: "Lenguajes",
                column: "ProyectoId",
                principalTable: "Proyectos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_Lenguajes_LenguajeId",
                table: "Proyectos",
                column: "LenguajeId",
                principalTable: "Lenguajes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lenguajes_Proyectos_ProyectoId",
                table: "Lenguajes");

            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_Lenguajes_LenguajeId",
                table: "Proyectos");

            migrationBuilder.DropIndex(
                name: "IX_Proyectos_LenguajeId",
                table: "Proyectos");

            migrationBuilder.DropIndex(
                name: "IX_Lenguajes_ProyectoId",
                table: "Lenguajes");

            migrationBuilder.DropColumn(
                name: "LenguajeId",
                table: "Proyectos");

            migrationBuilder.DropColumn(
                name: "ProyectoId",
                table: "Lenguajes");
        }
    }
}
