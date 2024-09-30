using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBGestaoEmpresarial.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Employes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    IdCargo = table.Column<int>(type: "int", nullable: false),
                    salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employes");
        }
    }
}
