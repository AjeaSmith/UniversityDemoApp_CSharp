using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityDemo.Migrations
{
    public partial class updateContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "EnrollmentDate",
                value: new DateTime(2019, 12, 28, 21, 15, 15, 363, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "EnrollmentDate",
                value: new DateTime(2019, 12, 28, 21, 15, 15, 383, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "EnrollmentDate",
                value: new DateTime(2019, 12, 28, 21, 15, 15, 383, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "EnrollmentDate",
                value: new DateTime(2019, 12, 28, 21, 15, 15, 383, DateTimeKind.Local).AddTicks(9640));
        }
    }
}
