using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agendify.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sericos",
                table: "Sericos");

            migrationBuilder.RenameTable(
                name: "Sericos",
                newName: "Servicos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servicos",
                table: "Servicos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Servicos",
                table: "Servicos");

            migrationBuilder.RenameTable(
                name: "Servicos",
                newName: "Sericos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sericos",
                table: "Sericos",
                column: "Id");
        }
    }
}
