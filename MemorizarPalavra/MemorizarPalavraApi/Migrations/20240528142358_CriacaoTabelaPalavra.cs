using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemorizarPalavraApi.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoTabelaPalavra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Palavras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalavraLinguaEstrangeira = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PalavraTraduzida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aprendido = table.Column<bool>(type: "bit", nullable: false),
                    DiaAtual = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProximaRevisao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NivelRevisao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palavras", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Palavras");
        }
    }
}
