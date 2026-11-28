using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaAtendimentos.Migrations
{
    /// <inheritdoc />
    public partial class AddExpediente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expedientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProfissionalId = table.Column<int>(type: "INTEGER", nullable: false),
                    DiaSemana = table.Column<int>(type: "INTEGER", nullable: false),
                    HoraInicio = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    HoraFim = table.Column<TimeOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expedientes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expedientes");
        }
    }
}
