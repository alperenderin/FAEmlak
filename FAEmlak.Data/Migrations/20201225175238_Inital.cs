using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAEmlak.Data.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Area = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PropertyType = table.Column<int>(nullable: false),
                    PropertyCategory = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    HasBalcony = table.Column<bool>(nullable: false),
                    HasStuff = table.Column<bool>(nullable: false),
                    BuildingAge = table.Column<byte>(nullable: false),
                    BathroomCount = table.Column<byte>(nullable: false),
                    IsInSite = table.Column<bool>(nullable: false),
                    FloorCount = table.Column<byte>(nullable: false),
                    WhichFloor = table.Column<byte>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Properties_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<long>(nullable: false),
                    PropertyId1 = table.Column<int>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photos_Properties_PropertyId1",
                        column: x => x.PropertyId1,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name" },
                values: new object[] { 1, "İstanbul" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name" },
                values: new object[] { 2, "Ankara" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Kartal" },
                    { 2, 1, "Kadıköy" },
                    { 3, 1, "Maltepe" },
                    { 4, 1, "Pendik" },
                    { 5, 1, "Ataşehir" },
                    { 6, 2, "Mamak" },
                    { 7, 2, "Beypazarı" },
                    { 8, 2, "Keçiören" },
                    { 9, 2, "Çankaya" },
                    { 10, 2, "Etimesgut" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Area", "BathroomCount", "BuildingAge", "Created", "Description", "FloorCount", "HasBalcony", "HasStuff", "IsInSite", "Price", "PropertyCategory", "PropertyType", "StateId", "Status", "Title", "WhichFloor" },
                values: new object[] { 1, 125, (byte)1, (byte)26, new DateTime(2020, 12, 25, 17, 52, 38, 91, DateTimeKind.Utc).AddTicks(230), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies commodo vehicula. Vestibulum pharetra ullamcorper ante, sit amet molestie eros imperdiet consequat. Integer dapibus urna vulputate consequat posuere. Aliquam erat volutpat. Integer non malesuada lectus. Vivamus ut mattis leo. Sed ornare nunc diam, eu sollicitudin est luctus at. Integer ante mauris, imperdiet vitae leo sit amet, semper pharetra lacus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", (byte)13, true, false, true, 850000, 0, 1, 2, 0, "SAHRAYICEDİT İNTAŞ SİTESİNDE PARK MANZARALI 3+1 DAİRE", (byte)2 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Area", "BathroomCount", "BuildingAge", "Created", "Description", "FloorCount", "HasBalcony", "HasStuff", "IsInSite", "Price", "PropertyCategory", "PropertyType", "StateId", "Status", "Title", "WhichFloor" },
                values: new object[] { 2, 125, (byte)1, (byte)26, new DateTime(2020, 12, 25, 17, 52, 38, 91, DateTimeKind.Utc).AddTicks(9427), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies commodo vehicula. Vestibulum pharetra ullamcorper ante, sit amet molestie eros imperdiet consequat. Integer dapibus urna vulputate consequat posuere. Aliquam erat volutpat. Integer non malesuada lectus. Vivamus ut mattis leo. Sed ornare nunc diam, eu sollicitudin est luctus at. Integer ante mauris, imperdiet vitae leo sit amet, semper pharetra lacus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", (byte)13, true, false, true, 516152, 0, 3, 2, 0, "Uğurmumcu Süper Bina Süper Fırsat", (byte)2 });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PropertyId1",
                table: "Photos",
                column: "PropertyId1");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_StateId",
                table: "Properties",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_States_CityId",
                table: "States",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
