using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Campeonato.DB.Futebol.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campeonatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomePopular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Região = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeonatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EdicoesAtuais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomePopular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temporada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampeonatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EdicoesAtuais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EdicoesAtuais_Campeonatos_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "Campeonatos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FasesAtuais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampeonatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FasesAtuais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FasesAtuais_Campeonatos_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "Campeonatos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RodadasAtuais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rodada = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampeonatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RodadasAtuais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RodadasAtuais_Campeonatos_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "Campeonatos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EdicoesAtuais_CampeonatoId",
                table: "EdicoesAtuais",
                column: "CampeonatoId",
                unique: true,
                filter: "[CampeonatoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FasesAtuais_CampeonatoId",
                table: "FasesAtuais",
                column: "CampeonatoId",
                unique: true,
                filter: "[CampeonatoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RodadasAtuais_CampeonatoId",
                table: "RodadasAtuais",
                column: "CampeonatoId",
                unique: true,
                filter: "[CampeonatoId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EdicoesAtuais");

            migrationBuilder.DropTable(
                name: "FasesAtuais");

            migrationBuilder.DropTable(
                name: "RodadasAtuais");

            migrationBuilder.DropTable(
                name: "Campeonatos");
        }
    }
}
