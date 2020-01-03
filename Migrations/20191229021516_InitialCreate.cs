using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityDemo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Credits = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    EnrollmentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CourseId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    Grade = table.Column<char>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Credits", "Title" },
                values: new object[] { 123, 3, "Math" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Credits", "Title" },
                values: new object[] { 234, 6, "Bio" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Credits", "Title" },
                values: new object[] { 432, 12, "Physics" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Credits", "Title" },
                values: new object[] { 110, 12, "Chemisty" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(2019, 12, 28, 21, 15, 15, 363, DateTimeKind.Local).AddTicks(6030), "William", "Shakespeare" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(2019, 12, 28, 21, 15, 15, 383, DateTimeKind.Local).AddTicks(9580), "James", "Blake" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 3, new DateTime(2019, 12, 28, 21, 15, 15, 383, DateTimeKind.Local).AddTicks(9630), "Franklin", "Stein" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 4, new DateTime(2019, 12, 28, 21, 15, 15, 383, DateTimeKind.Local).AddTicks(9640), "Craig", "Morris" });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "Grade", "StudentId" },
                values: new object[] { 1, 123, 'A', 1 });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "Grade", "StudentId" },
                values: new object[] { 2, 123, 'B', 2 });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "Grade", "StudentId" },
                values: new object[] { 3, 432, 'A', 3 });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "Grade", "StudentId" },
                values: new object[] { 4, 110, 'C', 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseId",
                table: "Enrollments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
