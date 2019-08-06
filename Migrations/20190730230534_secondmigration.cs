using Microsoft.EntityFrameworkCore.Migrations;

namespace GrandCircusUniversity.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentFistName",
                table: "Student",
                newName: "StudentFirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentFirstName",
                table: "Student",
                newName: "StudentFistName");
        }
    }
}
