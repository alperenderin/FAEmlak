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
                PropertyType = PropertyType.Buildings,
                Status = PropertyStatus.Active,
                HasBalcony = true,
                BathroomCount = 1,
                BuildingAge = 26,
                FloorCount = 13,
                WhichFloor = 2,
                HasStuff = false,
                IsInSite = true,
                StateId = 2
            });
        }
    }
}
