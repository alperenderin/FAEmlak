using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FAEmlak.Data;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace FAEmlak.Data.Concrete.EFCore
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<FavoriteItem> FavoriteItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Admin", NormalizedName = "ADMIN".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d5efd7210", Name = "User", NormalizedName = "USER".ToUpper() });

            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<User>();

            //Seeding the User to AspNetUsers table
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                    UserName = "g181210106@sakarya.edu.tr",
                    NormalizedEmail = "g181210106@sakarya.edu.tr".ToUpper(),
                    NormalizedUserName = "g181210106@sakarya.edu.tr".ToUpper(),
                    Email = "g181210106@sakarya.edu.tr",
                    FirstName = "Alperen",
                    LastName = "Derin",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123")
                }
            );

            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );

            //Seeding the User to AspNetUsers table
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "8e445865-a24d-4543-a8c6-9443d048cdb9", // primary key
                    UserName = "b181210091@sakarya.edu.tr",
                    NormalizedUserName = "b181210091@sakarya.edu.tr".ToUpper(),
                    NormalizedEmail = "b181210091@sakarya.edu.tr".ToUpper(),
                    Email = "b181210091@sakarya.edu.tr",
                    FirstName = "Furkan",
                    LastName = "Ergün",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123")
                }
            );

            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a8c6-9443d048cdb9"
                }
            );

            //Seeding the User to AspNetUsers table
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "1", // primary key
                    UserName = "denemeEmlak@deneme.com",
                    NormalizedEmail = "denemeEmlak@deneme.com".ToUpper(),
                    NormalizedUserName = "denemeEmlak@deneme.com".ToUpper(),
                    Email = "denemeEmlak@deneme.com",
                    FirstName = "Deneme",
                    LastName = "Emlak",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123")
                }
            );

            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d5efd7210",
                    UserId = "1"
                }
            );

            modelBuilder.Entity<City>().HasData(new City { CityId = 1, Name = "İstanbul" });
            modelBuilder.Entity<City>().HasData(new City { CityId = 2, Name = "Ankara" });

            modelBuilder.Entity<State>().HasData(new State { Id = 1, Name = "Kartal", CityId = 1 });
            modelBuilder.Entity<State>().HasData(new State { Id = 2, Name = "Kadıköy", CityId = 1 });
            modelBuilder.Entity<State>().HasData(new State { Id = 3, Name = "Maltepe", CityId = 1 });
            modelBuilder.Entity<State>().HasData(new State { Id = 4, Name = "Pendik", CityId = 1 });
            modelBuilder.Entity<State>().HasData(new State { Id = 5, Name = "Ataşehir", CityId = 1 });
            modelBuilder.Entity<State>().HasData(new State { Id = 6, Name = "Mamak", CityId = 2 });
            modelBuilder.Entity<State>().HasData(new State { Id = 7, Name = "Beypazarı", CityId = 2 });
            modelBuilder.Entity<State>().HasData(new State { Id = 8, Name = "Keçiören", CityId = 2 });
            modelBuilder.Entity<State>().HasData(new State { Id = 9, Name = "Çankaya", CityId = 2 });
            modelBuilder.Entity<State>().HasData(new State { Id = 10, Name = "Etimesgut", CityId = 2 });

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
                RoomCount = RoomCount.ThreePlusOne,
                HasBalcony = true,
                BathroomCount = 1,
                BuildingAge = 26,
                FloorCount = 13,
                WhichFloor = 2,
                HasStuff = false,
                IsInSite = true,
                StateId = 2,
                UserId = "1"
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
                StateId = 2,
                UserId = "1"
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
                StateId = 2,
                UserId = "1"
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
                StateId = 2,
                UserId = "1"
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
                StateId = 2,
                UserId = "1"
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
                StateId = 2,
                UserId = "1"
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
                StateId = 2,
                UserId = "1"
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
                StateId = 2,
                UserId = "1"
            });

            modelBuilder.Entity<Photo>().HasData(new Photo {PhotoId= 1, PropertyId = 1, PhotoPath = $"1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo {PhotoId= 2, PropertyId = 1, PhotoPath = $"2.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo {PhotoId= 3, PropertyId = 1, PhotoPath = $"3.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo {PhotoId= 4, PropertyId = 1, PhotoPath = $"4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo {PhotoId= 5, PropertyId = 1, PhotoPath = $"5.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo {PhotoId= 6, PropertyId = 1, PhotoPath = $"6.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo {PhotoId= 7, PropertyId = 1, PhotoPath = $"7.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 8, PropertyId = 2, PhotoPath = $"1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 9, PropertyId = 2, PhotoPath = $"2.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 10, PropertyId = 2, PhotoPath = $"3.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 11, PropertyId = 2, PhotoPath = $"4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 12, PropertyId = 2, PhotoPath = $"5.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 13, PropertyId = 2, PhotoPath = $"6.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 14, PropertyId = 2, PhotoPath = $"7.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 15, PropertyId = 3, PhotoPath = $"1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 16, PropertyId = 3, PhotoPath = $"2.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 17, PropertyId = 3, PhotoPath = $"3.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 18, PropertyId = 3, PhotoPath = $"4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 19, PropertyId = 3, PhotoPath = $"5.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 20, PropertyId = 3, PhotoPath = $"6.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 21, PropertyId = 3, PhotoPath = $"7.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 22, PropertyId = 4, PhotoPath = $"1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 23, PropertyId = 4, PhotoPath = $"2.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 24, PropertyId = 4, PhotoPath = $"3.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 25, PropertyId = 4, PhotoPath = $"4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 26, PropertyId = 4, PhotoPath = $"5.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 27, PropertyId = 4, PhotoPath = $"6.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 28, PropertyId = 4, PhotoPath = $"7.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 29, PropertyId = 5, PhotoPath = $"1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 30, PropertyId = 5, PhotoPath = $"2.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 31, PropertyId = 5, PhotoPath = $"3.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 32, PropertyId = 5, PhotoPath = $"4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 33, PropertyId = 5, PhotoPath = $"5.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 34, PropertyId = 5, PhotoPath = $"6.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 35, PropertyId = 5, PhotoPath = $"7.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 36, PropertyId = 6, PhotoPath = $"1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 37, PropertyId = 6, PhotoPath = $"2.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 38, PropertyId = 6, PhotoPath = $"3.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 39, PropertyId = 6, PhotoPath = $"4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 40, PropertyId = 6, PhotoPath = $"5.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 41, PropertyId = 6, PhotoPath = $"6.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 42, PropertyId = 6, PhotoPath = $"7.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 43, PropertyId = 7, PhotoPath = $"1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 44, PropertyId = 7, PhotoPath = $"2.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 45, PropertyId = 7, PhotoPath = $"3.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 46, PropertyId = 7, PhotoPath = $"4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 47, PropertyId = 7, PhotoPath = $"5.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 48, PropertyId = 7, PhotoPath = $"6.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 49, PropertyId = 7, PhotoPath = $"7.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 50, PropertyId = 8, PhotoPath = $"1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 51, PropertyId = 8, PhotoPath = $"2.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 52, PropertyId = 8, PhotoPath = $"3.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 53, PropertyId = 8, PhotoPath = $"4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 54, PropertyId = 8, PhotoPath = $"5.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 55, PropertyId = 8, PhotoPath = $"6.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { PhotoId = 56, PropertyId = 8, PhotoPath = $"7.jpg" });


        }
    }
}
