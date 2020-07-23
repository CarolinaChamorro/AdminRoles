using Microsoft.EntityFrameworkCore.Migrations;

namespace AfectacionMedioAmbiente.Web.Data.Migrations
{
    public partial class Actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "ImagenPerfil",
                table: "Usuarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenPerfil",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
