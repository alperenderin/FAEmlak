using System;
using System.Collections.Generic;
using System.ComponentModel;
using FAEmlak.Entity;

namespace FAEmlak.Models
{
    public class PropertyDetailViewModel
    {
        public Property property { get; set; }
        public bool IsFavorite { get; set; }


        public int ProductId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        [DisplayName("m²")]
        public int Area { get; set; }
        public string Description { get; set; }

        public PropertyType PropertyType { get; set; }
        public PropertyCategory PropertyCategory { get; set; }
        public PropertyStatus Status { get; set; }
        [DisplayName("Oda Sayısı")]
        public RoomCount RoomCount { get; set; }

        [DisplayName("Balkon")]
        public bool HasBalcony { get; set; }

        [DisplayName("Eşyalı")]
        public bool HasStuff { get; set; }

        [DisplayName("Bina Yaşı")]
        public byte BuildingAge { get; set; }

        [DisplayName("Banyo Sayısı")]
        public byte BathroomCount { get; set; }

        [DisplayName("Site İçerisinde")]
        public bool IsInSite { get; set; }

        [DisplayName("Kat Sayısı")]
        public byte FloorCount { get; set; }

        [DisplayName("Kaçıncı Kat")]
        public byte WhichFloor { get; set; }

        public int StateId { get; set; }
        public State State { get; set; }

        public List<Photo> Photos { get; set; }

        [DisplayName("İlan Tarihi")]
        public DateTime Created { get; internal set; }
    }
}
