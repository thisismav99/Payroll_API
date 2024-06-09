using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Payroll_System_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonthlySalary",
                table: "Salaries");

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 14, 30, 43, 418, DateTimeKind.Local).AddTicks(3912));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MonthlySalary",
                table: "Salaries",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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
    }
}
