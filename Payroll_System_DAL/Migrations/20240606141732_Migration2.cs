using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Payroll_System_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 6, 22, 17, 31, 668, DateTimeKind.Local).AddTicks(3270));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3752));
        }
    }
}
