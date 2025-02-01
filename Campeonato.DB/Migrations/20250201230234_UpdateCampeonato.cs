using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Campeonato.DB.Futebol.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCampeonato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Região",
                table: "Campeonatos",
                newName: "Regiao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Regiao",
                table: "Campeonatos",
                newName: "Região");
        }
    }
}
