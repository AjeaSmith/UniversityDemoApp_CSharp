using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityDemo.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "EnrollmentDate",
                value: new DateTime(2020, 1, 5, 20, 12, 21, 723, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "EnrollmentDate",
                value: new DateTime(2020, 1, 5, 20, 12, 21, 743, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "EnrollmentDate",
                value: new DateTime(2020, 1, 5, 20, 12, 21, 743, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "EnrollmentDate",
                value: new DateTime(2020, 1, 5, 20, 12, 21, 743, DateTimeKind.Local).AddTicks(5940));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "EnrollmentDate",
                value: new DateTime(2019, 12, 31, 0, 12, 36, 773, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "EnrollmentDate",
                value: new DateTime(2019, 12, 31, 0, 12, 36, 792, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "EnrollmentDate",
                value: new DateTime(2019, 12, 31, 0, 12, 36, 792, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "EnrollmentDate",
                value: new DateTime(2019, 12, 31, 0, 12, 36, 792, DateTimeKind.Local).AddTicks(1750));
        }
    }
}
