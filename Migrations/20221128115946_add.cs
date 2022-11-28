using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketSalesCurs.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "infoUser",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "infoFilm",
                table: "Films",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vieweds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vieweds", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_infoUser",
                table: "Users",
                column: "infoUser");

            migrationBuilder.CreateIndex(
                name: "IX_Films_infoFilm",
                table: "Films",
                column: "infoFilm");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Vieweds_infoFilm",
                table: "Films",
                column: "infoFilm",
                principalTable: "Vieweds",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Vieweds_infoUser",
                table: "Users",
                column: "infoUser",
                principalTable: "Vieweds",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Vieweds_infoFilm",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Vieweds_infoUser",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Vieweds");

            migrationBuilder.DropIndex(
                name: "IX_Users_infoUser",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Films_infoFilm",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "infoUser",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "infoFilm",
                table: "Films");
        }
    }
}
