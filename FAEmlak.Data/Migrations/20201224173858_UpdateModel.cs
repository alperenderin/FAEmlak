using Microsoft.EntityFrameworkCore.Migrations;

namespace FAEmlak.Data.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "BathroomCount",
                table: "Properties",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "BuildingAge",
                table: "Properties",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "FloorCount",
                table: "Properties",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<bool>(
                name: "HasBalcony",
                table: "Properties",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasStuff",
                table: "Properties",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInSite",
                table: "Properties",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte>(
                name: "WhichFloor",
                table: "Properties",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BathroomCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "BuildingAge",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "FloorCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "HasBalcony",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "HasStuff",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsInSite",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "WhichFloor",
                table: "Properties");
        }
    }
}
