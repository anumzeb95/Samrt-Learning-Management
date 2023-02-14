using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLM.Data.Migrations
{
    public partial class colec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leacture_Courses_CoursesId",
                table: "Leacture");

            migrationBuilder.DropIndex(
                name: "IX_Leacture_CoursesId",
                table: "Leacture");

            migrationBuilder.DropColumn(
                name: "CoursesId",
                table: "Leacture");

            migrationBuilder.AddColumn<int>(
                name: "CoursesId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leacture_CourseId",
                table: "Leacture",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CoursesId",
                table: "Courses",
                column: "CoursesId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserId",
                table: "Courses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Courses_CoursesId",
                table: "Courses",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_User_UserId",
                table: "Courses",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Leacture_Courses_CourseId",
                table: "Leacture",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Courses_CoursesId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_User_UserId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Leacture_Courses_CourseId",
                table: "Leacture");

            migrationBuilder.DropIndex(
                name: "IX_Leacture_CourseId",
                table: "Leacture");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CoursesId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_UserId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CoursesId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CoursesId",
                table: "Leacture",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leacture_CoursesId",
                table: "Leacture",
                column: "CoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leacture_Courses_CoursesId",
                table: "Leacture",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
