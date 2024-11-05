using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QBankApi.Migrations
{
    /// <inheritdoc />
    public partial class atualizaçaoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Contas");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Contas",
                newName: "NomeCliente");

            migrationBuilder.AddColumn<int>(
                name: "Cpf",
                table: "Contas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Contas");

            migrationBuilder.RenameColumn(
                name: "NomeCliente",
                table: "Contas",
                newName: "email");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Contas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
