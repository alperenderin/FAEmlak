using System;
using FAEmlak.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FAEmlak.Data.Concrete.EFCore
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<FavoriteItem>  FavoriteItems{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(new City { CityId = 1, Name = "İstanbul" });
            modelBuilder.Entity<City>().HasData(new City { CityId = 2, Name = "Ankara" });

            modelBuilder.Entity<State>().HasData(new State { Id=1,  Name = "Kartal", CityId = 1 });
            modelBuilder.Entity<State>().HasData(new State { Id=2, Name = "Kadıköy", CityId = 1 });
            modelBuilder.Entity<State>().HasData(new State { Id=3, Name = "Maltepe", CityId = 1 });
            modelBuilder.Entity<State>().HasData(new State { Id=4, Name = "Pendik", CityId = 1 });
            modelBuilder.Entity<State>().HasData(new State { Id=5, Name = "Ataşehir", CityId = 1 });
            modelBuilder.Entity<State>().HasData(new State { Id=6, Name = "Mamak", CityId = 2 });
            modelBuilder.Entity<State>().HasData(new State { Id=7, Name = "Beypazarı", CityId = 2 });
            modelBuilder.Entity<State>().HasData(new State { Id=8, Name = "Keçiören", CityId = 2 });
            modelBuilder.Entity<State>().HasData(new State { Id=9, Name = "Çankaya", CityId = 2 });
            modelBuilder.Entity<State>().HasData(new State { Id=10, Name = "Etimesgut", CityId = 2 });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                PropertyId = 1,
                Title = "SAHRAYICEDİT İNTAŞ SİTESİNDE PARK MANZARALI 3+1 DAİRE",
                Price = 850000,
                Area = 125,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies commodo vehicula. Vestibulum pharetra ullamcorper ante, sit amet molestie eros imperdiet consequat. Integer dapibus urna vulputate consequat posuere. Aliquam erat volutpat. Integer non malesuada lectus. Vivamus ut mattis leo. Sed ornare nunc diam, eu sollicitudin est luctus at. Integer ante mauris, imperdiet vitae leo sit amet, semper pharetra lacus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                PropertyType = PropertyType.Commercial,
                PropertyCategory = PropertyCategory.ForSale,
                Status = PropertyStatus.Active,
                RoomCount  = RoomCount.ThreePlusOne,
                HasBalcony = true,
                BathroomCount = 1,
                BuildingAge = 26,
                FloorCount = 13,
                WhichFloor = 2,
                HasStuff = false,
                IsInSite = true,
                StateId = 2
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                PropertyId = 2,
                Title = "Uğurmumcu Süper Bina Süper Fırsat",
                Price = 516152,
                Area = 125,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies commodo vehicula. Vestibulum pharetra ullamcorper ante, sit amet molestie eros imperdiet consequat. Integer dapibus urna vulputate consequat posuere. Aliquam erat volutpat. Integer non malesuada lectus. Vivamus ut mattis leo. Sed ornare nunc diam, eu sollicitudin est luctus at. Integer ante mauris, imperdiet vitae leo sit amet, semper pharetra lacus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                PropertyType = PropertyType.Buildings,
                PropertyCategory = PropertyCategory.ForSale,
                Status = PropertyStatus.Active,
                RoomCount = RoomCount.One,
                HasBalcony = true,
                BathroomCount = 1,
                BuildingAge = 26,
                FloorCount = 13,
                WhichFloor = 2,
                HasStuff = false,
                IsInSite = true,
                StateId = 2
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                PropertyId = 3,
                Title = "BEYLİKDÜZÜ KALEDEN HAFTANIN EN AVANTAJLI SATILIK 2+1 DAİRESİ !!!",
                Price = 220000,
                Area = 120,
                Description = "Isı Ve Ses Yalıtımı ile Yaz Kış Ferah ve Sessiz./nLed Spot ve Dekoratif Işıklandırma ile Şık ve Kullanış﻿lı﻿.",
                PropertyType = PropertyType.Buildings,
                PropertyCategory = PropertyCategory.ForSale,
                Status = PropertyStatus.Active,
                RoomCount = RoomCount.TwoPlusOne,
                HasBalcony = true,
                BathroomCount = 1,
                BuildingAge = 26,
                FloorCount = 10,
                WhichFloor = 5,
                HasStuff = false,
                IsInSite = true,
                StateId = 2
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                PropertyId = 4,
                Title = "ROTA YAPI'DAN İSKANLI,OTOPARKLI BUTİK SİTEDE 2+1 SATILIK DAİRE",
                Price = 419000,
                Area = 100,
                Description = "Betonarme Taşıyıcı Sistemleri/nIsı Yalıtımıyla Donatılmış Dış cephe Kaplama",
                PropertyType = PropertyType.Commercial,
                PropertyCategory = PropertyCategory.ForRent,
                Status = PropertyStatus.Active,
                HasBalcony = true,
                RoomCount = RoomCount.TwoPlusOne,
                BathroomCount = 2,
                BuildingAge = 16,
                FloorCount = 13,
                WhichFloor = 2,
                HasStuff = false,
                IsInSite = true,
                StateId = 2
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                PropertyId = 5,
                Title = "BEYLİKDÜZÜ'NDE DENİZ MANZARALI GENİŞ ULTRA LÜX DUBLEX FIRSATI",
                Price = 547452,
                Area = 105,
                Description = "Araçlarınız Binici Fiyatından Takas Yapılabilir",
                PropertyType = PropertyType.Land,
                PropertyCategory = PropertyCategory.DailyRental,
                Status = PropertyStatus.Active,
                RoomCount = RoomCount.FourPlusOne,
                HasBalcony = true,
                BathroomCount = 1,
                BuildingAge = 26,
                FloorCount = 13,
                WhichFloor = 2,
                HasStuff = false,
                IsInSite = true,
                StateId = 2
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                PropertyId = 6,
                Title = "BEYLİKDÜZÜNDE 35BİN NAKİT AYLIK 1450 TL ÖDEME İLE SATILIK DAİRE",
                Price = 134899,
                Area = 105,
                Description = "Araçlarınız Binici Fiyatından Takas Yapılabilir",
                PropertyCategory = PropertyCategory.ForRent,
                PropertyType = PropertyType.Residental,
                Status = PropertyStatus.Active,
                RoomCount = RoomCount.One,
                HasBalcony = true,
                BathroomCount = 1,
                BuildingAge = 26,
                FloorCount = 2,
                WhichFloor = 1,
                HasStuff = false,
                IsInSite = true,
                StateId = 2
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                PropertyId = 7,
                Title = "YILIN SON FIRSAT KELEPİR DAİRESİ 2+1 SATILIK DAİRE",
                Price = 220000,
                Area = 115,
                Description = "200m2 Yaşam Alanına Sahiptir.",
                PropertyCategory = PropertyCategory.ForRent,
                PropertyType = PropertyType.Residental,
                Status = PropertyStatus.Active,
                RoomCount = RoomCount.TwoPlusOne,
                HasBalcony = true,
                BathroomCount = 1,
                BuildingAge = 26,
                FloorCount = 1,
                WhichFloor = 1,
                HasStuff = false,
                IsInSite = true,
                StateId = 2
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                PropertyId = 8,
                Title = "Emlakoffice 3+1 200m2 Merkezde Satılık Geniş Daire",
                Price = 315000,
                Area = 105,
                Description = "Dairemiz Merkezi Konumda Olup Oldukça geniş Ve Kullanışlı Bir Dairedir..",
                PropertyType = PropertyType.Land,
                PropertyCategory = PropertyCategory.DailyRental,
                Status = PropertyStatus.Active,
                RoomCount = RoomCount.ThreePlusOne,
                HasBalcony = true,
                BathroomCount = 1,
                BuildingAge = 26,
                FloorCount = 5,
                WhichFloor = 2,
                HasStuff = false,
                IsInSite = true,
                StateId = 2
            });
        }
    }
}
