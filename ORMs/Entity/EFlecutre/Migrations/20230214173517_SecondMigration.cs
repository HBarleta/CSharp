using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFlecutre.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Monsters",
                table: "Monsters");

            migrationBuilder.RenameTable(
                name: "Monsters",
                newName: "Posts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Monsters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monsters",
                table: "Monsters",
                column: "PostId");
        }
    }
}
