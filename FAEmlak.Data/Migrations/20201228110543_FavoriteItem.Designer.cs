﻿// <auto-generated />
using System;
using FAEmlak.Data.Concrete.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAEmlak.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20201228110543_FavoriteItem")]
    partial class FavoriteItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAEmlak.Entity.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Name = "İstanbul"
                        },
                        new
                        {
                            CityId = 2,
                            Name = "Ankara"
                        });
                });

            modelBuilder.Entity("FAEmlak.Entity.FavoriteItem", b =>
                {
                    b.Property<int>("FavoriteItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FavoriteItemId");

                    b.HasIndex("PropertyId");

                    b.ToTable("FavoriteItems");
                });

            modelBuilder.Entity("FAEmlak.Entity.Photo", b =>
                {
                    b.Property<long>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<long>("PropertyId")
                        .HasColumnType("bigint");

                    b.Property<int?>("PropertyId1")
                        .HasColumnType("int");

                    b.HasKey("PhotoId");

                    b.HasIndex("PropertyId1");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("FAEmlak.Entity.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<byte>("BathroomCount")
                        .HasColumnType("tinyint");

                    b.Property<byte>("BuildingAge")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("FloorCount")
                        .HasColumnType("tinyint");

                    b.Property<bool>("HasBalcony")
                        .HasColumnType("bit");

                    b.Property<bool>("HasStuff")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInSite")
                        .HasColumnType("bit");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("PropertyCategory")
                        .HasColumnType("int");

                    b.Property<int>("PropertyType")
                        .HasColumnType("int");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("WhichFloor")
                        .HasColumnType("tinyint");

                    b.HasKey("PropertyId");

                    b.HasIndex("StateId");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            PropertyId = 1,
                            Area = 125,
                            BathroomCount = (byte)1,
                            BuildingAge = (byte)26,
                            Created = new DateTime(2020, 12, 28, 11, 5, 43, 297, DateTimeKind.Utc).AddTicks(1443),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies commodo vehicula. Vestibulum pharetra ullamcorper ante, sit amet molestie eros imperdiet consequat. Integer dapibus urna vulputate consequat posuere. Aliquam erat volutpat. Integer non malesuada lectus. Vivamus ut mattis leo. Sed ornare nunc diam, eu sollicitudin est luctus at. Integer ante mauris, imperdiet vitae leo sit amet, semper pharetra lacus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                            FloorCount = (byte)13,
                            HasBalcony = true,
                            HasStuff = false,
                            IsInSite = true,
                            Price = 850000,
                            PropertyCategory = 0,
                            PropertyType = 1,
                            StateId = 2,
                            Status = 0,
                            Title = "SAHRAYICEDİT İNTAŞ SİTESİNDE PARK MANZARALI 3+1 DAİRE",
                            WhichFloor = (byte)2
                        },
                        new
                        {
                            PropertyId = 2,
                            Area = 125,
                            BathroomCount = (byte)1,
                            BuildingAge = (byte)26,
                            Created = new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(1869),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies commodo vehicula. Vestibulum pharetra ullamcorper ante, sit amet molestie eros imperdiet consequat. Integer dapibus urna vulputate consequat posuere. Aliquam erat volutpat. Integer non malesuada lectus. Vivamus ut mattis leo. Sed ornare nunc diam, eu sollicitudin est luctus at. Integer ante mauris, imperdiet vitae leo sit amet, semper pharetra lacus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                            FloorCount = (byte)13,
                            HasBalcony = true,
                            HasStuff = false,
                            IsInSite = true,
                            Price = 516152,
                            PropertyCategory = 0,
                            PropertyType = 3,
                            StateId = 2,
                            Status = 0,
                            Title = "Uğurmumcu Süper Bina Süper Fırsat",
                            WhichFloor = (byte)2
                        },
                        new
                        {
                            PropertyId = 3,
                            Area = 120,
                            BathroomCount = (byte)1,
                            BuildingAge = (byte)26,
                            Created = new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2113),
                            Description = "Isı Ve Ses Yalıtımı ile Yaz Kış Ferah ve Sessiz./nLed Spot ve Dekoratif Işıklandırma ile Şık ve Kullanış﻿lı﻿.",
                            FloorCount = (byte)10,
                            HasBalcony = true,
                            HasStuff = false,
                            IsInSite = true,
                            Price = 220000,
                            PropertyCategory = 0,
                            PropertyType = 3,
                            StateId = 2,
                            Status = 0,
                            Title = "BEYLİKDÜZÜ KALEDEN HAFTANIN EN AVANTAJLI SATILIK 2+1 DAİRESİ !!!",
                            WhichFloor = (byte)5
                        },
                        new
                        {
                            PropertyId = 4,
                            Area = 100,
                            BathroomCount = (byte)2,
                            BuildingAge = (byte)16,
                            Created = new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2155),
                            Description = "Betonarme Taşıyıcı Sistemleri/nIsı Yalıtımıyla Donatılmış Dış cephe Kaplama",
                            FloorCount = (byte)13,
                            HasBalcony = true,
                            HasStuff = false,
                            IsInSite = true,
                            Price = 419000,
                            PropertyCategory = 1,
                            PropertyType = 1,
                            StateId = 2,
                            Status = 0,
                            Title = "ROTA YAPI'DAN İSKANLI,OTOPARKLI BUTİK SİTEDE 2+1 SATILIK DAİRE",
                            WhichFloor = (byte)2
                        },
                        new
                        {
                            PropertyId = 5,
                            Area = 105,
                            BathroomCount = (byte)1,
                            BuildingAge = (byte)26,
                            Created = new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2191),
                            Description = "Araçlarınız Binici Fiyatından Takas Yapılabilir",
                            FloorCount = (byte)13,
                            HasBalcony = true,
                            HasStuff = false,
                            IsInSite = true,
                            Price = 547452,
                            PropertyCategory = 2,
                            PropertyType = 2,
                            StateId = 2,
                            Status = 0,
                            Title = "BEYLİKDÜZÜ'NDE DENİZ MANZARALI GENİŞ ULTRA LÜX DUBLEX FIRSATI",
                            WhichFloor = (byte)2
                        },
                        new
                        {
                            PropertyId = 6,
                            Area = 105,
                            BathroomCount = (byte)1,
                            BuildingAge = (byte)26,
                            Created = new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2233),
                            Description = "Araçlarınız Binici Fiyatından Takas Yapılabilir",
                            FloorCount = (byte)2,
                            HasBalcony = true,
                            HasStuff = false,
                            IsInSite = true,
                            Price = 134899,
                            PropertyCategory = 1,
                            PropertyType = 0,
                            StateId = 2,
                            Status = 0,
                            Title = "BEYLİKDÜZÜNDE 35BİN NAKİT AYLIK 1450 TL ÖDEME İLE SATILIK DAİRE",
                            WhichFloor = (byte)1
                        },
                        new
                        {
                            PropertyId = 7,
                            Area = 115,
                            BathroomCount = (byte)1,
                            BuildingAge = (byte)26,
                            Created = new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2270),
                            Description = "200m2 Yaşam Alanına Sahiptir.",
                            FloorCount = (byte)1,
                            HasBalcony = true,
                            HasStuff = false,
                            IsInSite = true,
                            Price = 220000,
                            PropertyCategory = 1,
                            PropertyType = 0,
                            StateId = 2,
                            Status = 0,
                            Title = "YILIN SON FIRSAT KELEPİR DAİRESİ 2+1 SATILIK DAİRE",
                            WhichFloor = (byte)1
                        },
                        new
                        {
                            PropertyId = 8,
                            Area = 105,
                            BathroomCount = (byte)1,
                            BuildingAge = (byte)26,
                            Created = new DateTime(2020, 12, 28, 11, 5, 43, 298, DateTimeKind.Utc).AddTicks(2305),
                            Description = "Dairemiz Merkezi Konumda Olup Oldukça geniş Ve Kullanışlı Bir Dairedir..",
                            FloorCount = (byte)5,
                            HasBalcony = true,
                            HasStuff = false,
                            IsInSite = true,
                            Price = 315000,
                            PropertyCategory = 2,
                            PropertyType = 2,
                            StateId = 2,
                            Status = 0,
                            Title = "Emlakoffice 3+1 200m2 Merkezde Satılık Geniş Daire",
                            WhichFloor = (byte)2
                        });
                });

            modelBuilder.Entity("FAEmlak.Entity.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Kartal"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Name = "Kadıköy"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 1,
                            Name = "Maltepe"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 1,
                            Name = "Pendik"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 1,
                            Name = "Ataşehir"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 2,
                            Name = "Mamak"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 2,
                            Name = "Beypazarı"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 2,
                            Name = "Keçiören"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 2,
                            Name = "Çankaya"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 2,
                            Name = "Etimesgut"
                        });
                });

            modelBuilder.Entity("FAEmlak.Entity.FavoriteItem", b =>
                {
                    b.HasOne("FAEmlak.Entity.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAEmlak.Entity.Photo", b =>
                {
                    b.HasOne("FAEmlak.Entity.Property", "Property")
                        .WithMany("Photos")
                        .HasForeignKey("PropertyId1");
                });

            modelBuilder.Entity("FAEmlak.Entity.Property", b =>
                {
                    b.HasOne("FAEmlak.Entity.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAEmlak.Entity.State", b =>
                {
                    b.HasOne("FAEmlak.Entity.City", "City")
                        .WithMany("States")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}