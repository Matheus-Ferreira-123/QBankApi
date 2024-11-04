using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QBankApi.Migrations
{
    /// <inheritdoc />
    public partial class atualização : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Contas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Contas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Contas");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Contas");
        }
    }
}
