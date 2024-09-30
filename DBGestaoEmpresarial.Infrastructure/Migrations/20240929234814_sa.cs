using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBGestaoEmpresarial.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "salario",
                table: "Employes",
                newName: "Salario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salario",
                table: "Employes",
                newName: "salario");
        }
    }
}
