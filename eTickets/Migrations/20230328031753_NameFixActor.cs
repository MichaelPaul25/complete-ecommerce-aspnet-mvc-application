using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class NameFixActor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actor_ActorId",
                table: "Actor_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "Actor",
                newName: "Actors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actors_ActorId",
                table: "Actor_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actors_ActorId",
                table: "Actor_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "Actor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                table: "Actor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actor_ActorId",
                table: "Actor_Movies",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
