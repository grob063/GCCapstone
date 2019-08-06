using Microsoft.EntityFrameworkCore.Migrations;

namespace GrandCircusUniversity.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "AdministratorId", "CourseName", "isFullTime", "isPartTime" },
                values: new object[] { 1, null, "C#", true, false });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "AdministratorId", "CourseName", "isFullTime", "isPartTime" },
                values: new object[] { 2, null, "JavaScript", false, true });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "AdministratorId", "CourseName", "isFullTime", "isPartTime" },
                values: new object[] { 3, null, ".Net Core", true, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3);
        }
    }
}
