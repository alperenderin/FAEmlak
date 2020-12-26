using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAEmlak.Data.Migrations
{
    public partial class sampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 12, 26, 14, 40, 56, 226, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 12, 26, 14, 40, 56, 226, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Area", "BathroomCount", "BuildingAge", "Created", "Description", "FloorCount", "HasBalcony", "HasStuff", "IsInSite", "Price", "PropertyCategory", "PropertyType", "StateId", "Status", "Title", "WhichFloor" },
                values: new object[,]
                {
                    { 3, 120, (byte)1, (byte)26, new DateTime(2020, 12, 26, 14, 40, 56, 226, DateTimeKind.Utc).AddTicks(9184), "Isı Ve Ses Yalıtımı ile Yaz Kış Ferah ve Sessiz./nLed Spot ve Dekoratif Işıklandırma ile Şık ve Kullanış﻿lı﻿.", (byte)10, true, false, true, 220000, 0, 3, 2, 0, "BEYLİKDÜZÜ KALEDEN HAFTANIN EN AVANTAJLI SATILIK 2+1 DAİRESİ !!!", (byte)5 },
                    { 4, 100, (byte)2, (byte)16, new DateTime(2020, 12, 26, 14, 40, 56, 226, DateTimeKind.Utc).AddTicks(9207), "Betonarme Taşıyıcı Sistemleri/nIsı Yalıtımıyla Donatılmış Dış cephe Kaplama", (byte)13, true, false, true, 419000, 1, 1, 2, 0, "ROTA YAPI'DAN İSKANLI,OTOPARKLI BUTİK SİTEDE 2+1 SATILIK DAİRE", (byte)2 },
                    { 5, 105, (byte)1, (byte)26, new DateTime(2020, 12, 26, 14, 40, 56, 226, DateTimeKind.Utc).AddTicks(9226), "Araçlarınız Binici Fiyatından Takas Yapılabilir", (byte)13, true, false, true, 547452, 2, 2, 2, 0, "BEYLİKDÜZÜ'NDE DENİZ MANZARALI GENİŞ ULTRA LÜX DUBLEX FIRSATI", (byte)2 },
                    { 6, 105, (byte)1, (byte)26, new DateTime(2020, 12, 26, 14, 40, 56, 226, DateTimeKind.Utc).AddTicks(9246), "Araçlarınız Binici Fiyatından Takas Yapılabilir", (byte)2, true, false, true, 134899, 1, 0, 2, 0, "BEYLİKDÜZÜNDE 35BİN NAKİT AYLIK 1450 TL ÖDEME İLE SATILIK DAİRE", (byte)1 },
                    { 7, 115, (byte)1, (byte)26, new DateTime(2020, 12, 26, 14, 40, 56, 226, DateTimeKind.Utc).AddTicks(9263), "200m2 Yaşam Alanına Sahiptir.", (byte)1, true, false, true, 220000, 1, 0, 2, 0, "YILIN SON FIRSAT KELEPİR DAİRESİ 2+1 SATILIK DAİRE", (byte)1 },
                    { 8, 105, (byte)1, (byte)26, new DateTime(2020, 12, 26, 14, 40, 56, 226, DateTimeKind.Utc).AddTicks(9279), "Dairemiz Merkezi Konumda Olup Oldukça geniş Ve Kullanışlı Bir Dairedir..", (byte)5, true, false, true, 315000, 2, 2, 2, 0, "Emlakoffice 3+1 200m2 Merkezde Satılık Geniş Daire", (byte)2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 12, 25, 17, 52, 38, 91, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 12, 25, 17, 52, 38, 91, DateTimeKind.Utc).AddTicks(9427));
        }
    }
}
