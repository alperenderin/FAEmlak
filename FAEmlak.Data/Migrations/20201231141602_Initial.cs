using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAEMlak.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

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
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Area = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PropertyType = table.Column<int>(nullable: false),
                    PropertyCategory = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    RoomCount = table.Column<int>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Properties_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteItems",
                columns: table => new
                {
                    FavoriteItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    PropertyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteItems", x => x.FavoriteItemId);
                    table.ForeignKey(
                        name: "FK_FavoriteItems_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoPath = table.Column<string>(nullable: true),
                    PropertyId = table.Column<int>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photos_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "539a644f-54ad-427d-9473-737ca4ee23b8", "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d5efd7210", "e67b1846-b66c-4c23-bef0-b34efc20437c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name" },
                values: new object[,]
                {
                    { 1, "İstanbul" },
                    { 2, "Ankara" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, null, "04315281-0478-4501-9124-5f9622ff04ca", new DateTime(2020, 12, 31, 14, 16, 1, 716, DateTimeKind.Utc).AddTicks(4150), "g181210106@sakarya.edu.tr", true, "Alperen", "Derin", false, null, "G181210106@SAKARYA.EDU.TR", "G181210106@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEATS4ydg3cqDDeF9qml5e13SnjfR227XAps4xZ2NVTHHq78Th41qFJe24X7RD28Hug==", null, false, "deb2e643-7d20-4544-a154-5eb84fa2d435", false, "g181210106@sakarya.edu.tr" },
                    { "8e445865-a24d-4543-a8c6-9443d048cdb9", 0, null, "62dda824-98a2-4ed6-a53d-a3fce76c6f4f", new DateTime(2020, 12, 31, 14, 16, 1, 732, DateTimeKind.Utc).AddTicks(5180), "b181210091@sakarya.edu.tr", true, "Furkan", "Ergün", false, null, "B181210091@SAKARYA.EDU.TR", "B181210091@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEGPmlYNUoY1iZgG0EdwmSoIPMA53DGtbJ1hlb+ZJnOmzFO3BpuRy88ez/eZ33wkRbw==", null, false, "bf0713e4-5389-415f-82af-9c6b98e76ca3", false, "b181210091@sakarya.edu.tr" },
                    { "1", 0, null, "6c54e0ed-bafa-45e1-a080-847d5a362027", new DateTime(2020, 12, 31, 14, 16, 1, 741, DateTimeKind.Utc).AddTicks(9490), "denemeEmlak@deneme.com", true, "Deneme", "Emlak", false, null, "DENEMEEMLAK@DENEME.COM", "DENEMEEMLAK@DENEME.COM", "AQAAAAEAACcQAAAAENPNWLviau8lLCFYus2Hxpa/6BW0Fpj0SXQC3Zt2unfHq2Em92qDgzUTp2hUrDjTow==", null, false, "694b918a-ecb5-4ecd-8eca-91eba979b09c", false, "denemeEmlak@deneme.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", "2c5e174e-3b0e-446f-86af-483d56fd7210" },
                    { "8e445865-a24d-4543-a8c6-9443d048cdb9", "2c5e174e-3b0e-446f-86af-483d56fd7210" },
                    { "1", "2c5e174e-3b0e-446f-86af-483d5efd7210" }
                });

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
                columns: new[] { "PropertyId", "Area", "BathroomCount", "BuildingAge", "Created", "Description", "FloorCount", "HasBalcony", "HasStuff", "IsInSite", "Price", "PropertyCategory", "PropertyType", "RoomCount", "StateId", "Status", "Title", "UserId", "WhichFloor" },
                values: new object[,]
                {
                    { 1, 125, (byte)1, (byte)26, new DateTime(2020, 12, 31, 14, 16, 1, 751, DateTimeKind.Utc).AddTicks(5500), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies commodo vehicula. Vestibulum pharetra ullamcorper ante, sit amet molestie eros imperdiet consequat. Integer dapibus urna vulputate consequat posuere. Aliquam erat volutpat. Integer non malesuada lectus. Vivamus ut mattis leo. Sed ornare nunc diam, eu sollicitudin est luctus at. Integer ante mauris, imperdiet vitae leo sit amet, semper pharetra lacus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", (byte)13, true, false, true, 850000, 0, 1, 3, 2, 0, "SAHRAYICEDİT İNTAŞ SİTESİNDE PARK MANZARALI 3+1 DAİRE", "1", (byte)2 },
                    { 2, 125, (byte)1, (byte)26, new DateTime(2020, 12, 31, 14, 16, 1, 752, DateTimeKind.Utc).AddTicks(1160), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies commodo vehicula. Vestibulum pharetra ullamcorper ante, sit amet molestie eros imperdiet consequat. Integer dapibus urna vulputate consequat posuere. Aliquam erat volutpat. Integer non malesuada lectus. Vivamus ut mattis leo. Sed ornare nunc diam, eu sollicitudin est luctus at. Integer ante mauris, imperdiet vitae leo sit amet, semper pharetra lacus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", (byte)13, true, false, true, 516152, 0, 3, 0, 2, 0, "Uğurmumcu Süper Bina Süper Fırsat", "1", (byte)2 },
                    { 3, 120, (byte)1, (byte)26, new DateTime(2020, 12, 31, 14, 16, 1, 752, DateTimeKind.Utc).AddTicks(1310), "Isı Ve Ses Yalıtımı ile Yaz Kış Ferah ve Sessiz./nLed Spot ve Dekoratif Işıklandırma ile Şık ve Kullanış﻿lı﻿.", (byte)10, true, false, true, 220000, 0, 3, 2, 2, 0, "BEYLİKDÜZÜ KALEDEN HAFTANIN EN AVANTAJLI SATILIK 2+1 DAİRESİ !!!", "1", (byte)5 },
                    { 4, 100, (byte)2, (byte)16, new DateTime(2020, 12, 31, 14, 16, 1, 752, DateTimeKind.Utc).AddTicks(1330), "Betonarme Taşıyıcı Sistemleri/nIsı Yalıtımıyla Donatılmış Dış cephe Kaplama", (byte)13, true, false, true, 419000, 1, 1, 2, 2, 0, "ROTA YAPI'DAN İSKANLI,OTOPARKLI BUTİK SİTEDE 2+1 SATILIK DAİRE", "1", (byte)2 },
                    { 5, 105, (byte)1, (byte)26, new DateTime(2020, 12, 31, 14, 16, 1, 752, DateTimeKind.Utc).AddTicks(1350), "Araçlarınız Binici Fiyatından Takas Yapılabilir", (byte)13, true, false, true, 547452, 2, 2, 4, 2, 0, "BEYLİKDÜZÜ'NDE DENİZ MANZARALI GENİŞ ULTRA LÜX DUBLEX FIRSATI", "1", (byte)2 },
                    { 6, 105, (byte)1, (byte)26, new DateTime(2020, 12, 31, 14, 16, 1, 752, DateTimeKind.Utc).AddTicks(1360), "Araçlarınız Binici Fiyatından Takas Yapılabilir", (byte)2, true, false, true, 134899, 1, 0, 0, 2, 0, "BEYLİKDÜZÜNDE 35BİN NAKİT AYLIK 1450 TL ÖDEME İLE SATILIK DAİRE", "1", (byte)1 },
                    { 7, 115, (byte)1, (byte)26, new DateTime(2020, 12, 31, 14, 16, 1, 752, DateTimeKind.Utc).AddTicks(1380), "200m2 Yaşam Alanına Sahiptir.", (byte)1, true, false, true, 220000, 1, 0, 2, 2, 0, "YILIN SON FIRSAT KELEPİR DAİRESİ 2+1 SATILIK DAİRE", "1", (byte)1 },
                    { 8, 105, (byte)1, (byte)26, new DateTime(2020, 12, 31, 14, 16, 1, 752, DateTimeKind.Utc).AddTicks(1390), "Dairemiz Merkezi Konumda Olup Oldukça geniş Ve Kullanışlı Bir Dairedir..", (byte)5, true, false, true, 315000, 2, 2, 3, 2, 0, "Emlakoffice 3+1 200m2 Merkezde Satılık Geniş Daire", "1", (byte)2 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "IsDefault", "PhotoPath", "PropertyId" },
                values: new object[,]
                {
                    { 1L, false, "1.jpg", 1 },
                    { 31L, false, "3.jpg", 5 },
                    { 32L, false, "4.jpg", 5 },
                    { 33L, false, "5.jpg", 5 },
                    { 34L, false, "6.jpg", 5 },
                    { 35L, false, "7.jpg", 5 },
                    { 36L, false, "1.jpg", 6 },
                    { 37L, false, "2.jpg", 6 },
                    { 38L, false, "3.jpg", 6 },
                    { 39L, false, "4.jpg", 6 },
                    { 40L, false, "5.jpg", 6 },
                    { 41L, false, "6.jpg", 6 },
                    { 30L, false, "2.jpg", 5 },
                    { 42L, false, "7.jpg", 6 },
                    { 44L, false, "2.jpg", 7 },
                    { 45L, false, "3.jpg", 7 },
                    { 46L, false, "4.jpg", 7 },
                    { 47L, false, "5.jpg", 7 },
                    { 48L, false, "6.jpg", 7 },
                    { 49L, false, "7.jpg", 7 },
                    { 50L, false, "1.jpg", 8 },
                    { 51L, false, "2.jpg", 8 },
                    { 52L, false, "3.jpg", 8 },
                    { 53L, false, "4.jpg", 8 },
                    { 54L, false, "5.jpg", 8 },
                    { 43L, false, "1.jpg", 7 },
                    { 29L, false, "1.jpg", 5 },
                    { 28L, false, "7.jpg", 4 },
                    { 27L, false, "6.jpg", 4 },
                    { 2L, false, "2.jpg", 1 },
                    { 3L, false, "3.jpg", 1 },
                    { 4L, false, "4.jpg", 1 },
                    { 5L, false, "5.jpg", 1 },
                    { 6L, false, "6.jpg", 1 },
                    { 7L, false, "7.jpg", 1 },
                    { 8L, false, "1.jpg", 2 },
                    { 9L, false, "2.jpg", 2 },
                    { 10L, false, "3.jpg", 2 },
                    { 11L, false, "4.jpg", 2 },
                    { 12L, false, "5.jpg", 2 },
                    { 13L, false, "6.jpg", 2 },
                    { 14L, false, "7.jpg", 2 },
                    { 15L, false, "1.jpg", 3 },
                    { 16L, false, "2.jpg", 3 },
                    { 17L, false, "3.jpg", 3 },
                    { 18L, false, "4.jpg", 3 },
                    { 19L, false, "5.jpg", 3 },
                    { 20L, false, "6.jpg", 3 },
                    { 21L, false, "7.jpg", 3 },
                    { 22L, false, "1.jpg", 4 },
                    { 23L, false, "2.jpg", 4 },
                    { 24L, false, "3.jpg", 4 },
                    { 25L, false, "4.jpg", 4 },
                    { 26L, false, "5.jpg", 4 },
                    { 55L, false, "6.jpg", 8 },
                    { 56L, false, "7.jpg", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteItems_PropertyId",
                table: "FavoriteItems",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PropertyId",
                table: "Photos",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_StateId",
                table: "Properties",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UserId",
                table: "Properties",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_States_CityId",
                table: "States",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FavoriteItems");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
