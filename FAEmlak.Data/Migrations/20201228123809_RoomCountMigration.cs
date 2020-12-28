using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAEmlak.Data.Migrations
{
    public partial class RoomCountMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomCount",
                table: "Properties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                columns: new[] { "Created", "RoomCount" },
                values: new object[] { new DateTime(2020, 12, 28, 12, 38, 8, 547, DateTimeKind.Utc).AddTicks(2460), 3 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 12, 28, 12, 38, 8, 548, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                columns: new[] { "Created", "RoomCount" },
                values: new object[] { new DateTime(2020, 12, 28, 12, 38, 8, 548, DateTimeKind.Utc).AddTicks(4281), 2 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                columns: new[] { "Created", "RoomCount" },
                values: new object[] { new DateTime(2020, 12, 28, 12, 38, 8, 548, DateTimeKind.Utc).AddTicks(4327), 2 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                columns: new[] { "Created", "RoomCount" },
                values: new object[] { new DateTime(2020, 12, 28, 12, 38, 8, 548, DateTimeKind.Utc).AddTicks(4367), 4 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2020, 12, 28, 12, 38, 8, 548, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 7,
                columns: new[] { "Created", "RoomCount" },
                values: new object[] { new DateTime(2020, 12, 28, 12, 38, 8, 548, DateTimeKind.Utc).AddTicks(4449), 2 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 8,
                columns: new[] { "Created", "RoomCount" },
                values: new object[] { new DateTime(2020, 12, 28, 12, 38, 8, 548, DateTimeKind.Utc).AddTicks(4487), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomCount",
                table: "Properties");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 12, 28, 11, 5, 43, 297, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2305));
        }
    }
}
