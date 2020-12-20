using Microsoft.EntityFrameworkCore.Migrations;

namespace PortafolioProyectos.Migrations
{
    public partial class proyecto3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proyecto_Clientes_ClienteId",
                table: "Proyecto");

            migrationBuilder.DropForeignKey(
                name: "FK_Proyecto_Estados_EstadoId",
                table: "Proyecto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proyecto",
                table: "Proyecto");

            migrationBuilder.RenameTable(
                name: "Proyecto",
                newName: "Proyectos");

            migrationBuilder.RenameIndex(
                name: "IX_Proyecto_EstadoId",
                table: "Proyectos",
                newName: "IX_Proyectos_EstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Proyecto_ClienteId",
                table: "Proyectos",
                newName: "IX_Proyectos_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proyectos",
                table: "Proyectos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_Clientes_ClienteId",
                table: "Proyectos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_Estados_EstadoId",
                table: "Proyectos",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_Clientes_ClienteId",
                table: "Proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_Estados_EstadoId",
                table: "Proyectos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proyectos",
                table: "Proyectos");

            migrationBuilder.RenameTable(
                name: "Proyectos",
                newName: "Proyecto");

            migrationBuilder.RenameIndex(
                name: "IX_Proyectos_EstadoId",
                table: "Proyecto",
                newName: "IX_Proyecto_EstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Proyectos_ClienteId",
                table: "Proyecto",
                newName: "IX_Proyecto_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proyecto",
                table: "Proyecto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Proyecto_Clientes_ClienteId",
                table: "Proyecto",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyecto_Estados_EstadoId",
                table: "Proyecto",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
