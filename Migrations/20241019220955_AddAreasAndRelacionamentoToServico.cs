using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Agendify.Migrations
{
    /// <inheritdoc />
    public partial class AddAreasAndRelacionamentoToServico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaDeAtuacaoId",
                table: "Servicos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 1); // Set a valid default value that matches an existing Area ID

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Construcao" },
                    { 2, "Informatica" },
                    { 3, "Medico" },
                    { 4, "Beleza" },
                    { 5, "Educacao" },
                    { 6, "Transporte" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_AreaDeAtuacaoId",
                table: "Servicos",
                column: "AreaDeAtuacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Areas_AreaDeAtuacaoId",
                table: "Servicos",
                column: "AreaDeAtuacaoId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Areas_AreaDeAtuacaoId",
                table: "Servicos");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_AreaDeAtuacaoId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "AreaDeAtuacaoId",
                table: "Servicos");
        }
    }
}
