using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBGestaoEmpresarial.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangesEmploye : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employes",
                type: "VARCHAR(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Employes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefones",
                table: "Employes",
                type: "VARCHAR(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "idFuncionario",
                table: "Employes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "Telefones",
                table: "Employes");

            migrationBuilder.DropColumn(
                name: "idFuncionario",
                table: "Employes");
        }
    }
}
