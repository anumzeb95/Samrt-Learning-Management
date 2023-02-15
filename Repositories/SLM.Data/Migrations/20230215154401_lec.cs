using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLM.Data.Migrations
{
    public partial class lec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Courses_CoursesId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CoursesId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CoursesId",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CoursesId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CoursesId",
                table: "Courses",
                column: "CoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Courses_CoursesId",
                table: "Courses",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
