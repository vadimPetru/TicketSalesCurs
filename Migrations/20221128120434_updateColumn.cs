using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketSalesCurs.Migrations
{
    /// <inheritdoc />
    public partial class updateColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilmsIdFilmId",
                table: "Vieweds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersIdId",
                table: "Vieweds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vieweds_FilmsIdFilmId",
                table: "Vieweds",
                column: "FilmsIdFilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Vieweds_UsersIdId",
                table: "Vieweds",
                column: "UsersIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vieweds_Films_FilmsIdFilmId",
                table: "Vieweds",
                column: "FilmsIdFilmId",
                principalTable: "Films",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vieweds_Users_UsersIdId",
                table: "Vieweds",
                column: "UsersIdId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vieweds_Films_FilmsIdFilmId",
                table: "Vieweds");

            migrationBuilder.DropForeignKey(
                name: "FK_Vieweds_Users_UsersIdId",
                table: "Vieweds");

            migrationBuilder.DropIndex(
                name: "IX_Vieweds_FilmsIdFilmId",
                table: "Vieweds");

            migrationBuilder.DropIndex(
                name: "IX_Vieweds_UsersIdId",
                table: "Vieweds");

            migrationBuilder.DropColumn(
                name: "FilmsIdFilmId",
                table: "Vieweds");

            migrationBuilder.DropColumn(
                name: "UsersIdId",
                table: "Vieweds");
        }
    }
}
