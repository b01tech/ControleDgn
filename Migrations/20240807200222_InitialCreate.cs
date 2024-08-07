using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDgn.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Padrao",
                columns: table => new
                {
                    PadraoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tag = table.Column<string>(type: "TEXT", nullable: false),
                    Certificado = table.Column<string>(type: "TEXT", nullable: false),
                    DataCal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Frequencia = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    ValorNominal = table.Column<double>(type: "REAL", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padrao", x => x.PadraoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Padrao");
        }
    }
}
