using Microsoft.EntityFrameworkCore.Migrations;

namespace PortafolioProyectos.Migrations
{
    public partial class proyecto5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LenguajesPorProyectos",
                columns: table => new
                {
                    LenguajeId = table.Column<int>(nullable: false),
                    ProyectoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LenguajesPorProyectos", x => new { x.LenguajeId, x.ProyectoId });
                    table.ForeignKey(
                        name: "FK_LenguajesPorProyectos_Lenguajes_LenguajeId",
                        column: x => x.LenguajeId,
                        principalTable: "Lenguajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LenguajesPorProyectos_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LenguajesPorProyectos_ProyectoId",
                table: "LenguajesPorProyectos",
                column: "ProyectoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LenguajesPorProyectos");
        }
    }
}
