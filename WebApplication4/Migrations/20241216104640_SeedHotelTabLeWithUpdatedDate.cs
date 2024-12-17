﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class SeedHotelTabLeWithUpdatedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 16, 39, 614, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 12, 16, 16, 16, 39, 614, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 16, 39, 614, DateTimeKind.Local).AddTicks(3212), new DateTime(2024, 12, 16, 16, 16, 39, 614, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 16, 39, 614, DateTimeKind.Local).AddTicks(3214), new DateTime(2024, 12, 16, 16, 16, 39, 614, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 16, 39, 614, DateTimeKind.Local).AddTicks(3216), new DateTime(2024, 12, 16, 16, 16, 39, 614, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 16, 39, 614, DateTimeKind.Local).AddTicks(3219), new DateTime(2024, 12, 16, 16, 16, 39, 614, DateTimeKind.Local).AddTicks(3219) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 16, 7, 48, DateTimeKind.Local).AddTicks(3270), new DateTime(2024, 12, 16, 16, 16, 7, 48, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 16, 7, 48, DateTimeKind.Local).AddTicks(3285), new DateTime(2024, 12, 16, 16, 16, 7, 48, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 16, 7, 48, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 12, 16, 16, 16, 7, 48, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 16, 7, 48, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 12, 16, 16, 16, 7, 48, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 16, 7, 48, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 12, 16, 16, 16, 7, 48, DateTimeKind.Local).AddTicks(3294) });
        }
    }
}