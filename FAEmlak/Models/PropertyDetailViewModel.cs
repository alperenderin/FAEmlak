using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FAEmlak.Data;

namespace FAEmlak.Models
{
    public class PropertyDetailViewModel
    {
        public Property property { get; set; }
        public bool IsFavorite { get; set; }

        public User user { get; set; }

        public int ProductId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        [Display(Name = "Area")]
        public int Area { get; set; }
        public string Description { get; set; }

        public PropertyType PropertyType { get; set; }
        public PropertyCategory PropertyCategory { get; set; }
        public PropertyStatus Status { get; set; }
        [DisplayName("RoomCount")]
        public RoomCount RoomCount { get; set; }

        [Display(Name = "HasBalcony")]
        public bool HasBalcony { get; set; }

        [Display(Name = "HasStuff")]
        public bool HasStuff { get; set; }

        [Display(Name = "BuildingAge")]
        public byte BuildingAge { get; set; }

        [Display(Name = "BahtroomCount")]
        public byte BathroomCount { get; set; }

        [Display(Name = "IsInSite")]
        public bool IsInSite { get; set; }

        [Display(Name = "FloorCount")]
        public byte FloorCount { get; set; }

        [Display(Name = "WhichFloor")]
        public byte WhichFloor { get; set; }

        public int StateId { get; set; }
        public State State { get; set; }

        public List<Photo> Photos { get; set; }

        [Display(Name = "Created")]
        public DateTime Created { get; internal set; }
    }
}
