using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Payroll_System_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 9, 16, 14, 39, 154, DateTimeKind.Local).AddTicks(4697));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
