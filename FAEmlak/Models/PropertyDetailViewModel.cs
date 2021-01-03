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

        public int PropertyId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Area")]
        public int Area { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "PropertyType")]
        public PropertyType PropertyType { get; set; }

        [Required]
        [Display(Name = "PropertyCategory")]
        public PropertyCategory PropertyCategory { get; set; }

        public PropertyStatus Status { get; set; }

        [Required]
        [DisplayName("RoomCount")]
        public RoomCount RoomCount { get; set; }

        [Required]
        [Display(Name = "HasBalcony")]
        public bool HasBalcony { get; set; }

        [Required]
        [Display(Name = "HasStuff")]
        public bool HasStuff { get; set; }


        [Required]
        [Display(Name = "BuildingAge")]
        public byte BuildingAge { get; set; }

        [Required]
        [Display(Name = "BahtroomCount")]
        public byte BathroomCount { get; set; }

        [Required]
        [Display(Name = "IsInSite")]
        public bool IsInSite { get; set; }

        [Required]
        [Display(Name = "FloorCount")]
        public byte FloorCount { get; set; }

        [Required]
        [Display(Name = "WhichFloor")]
        public byte WhichFloor { get; set; }

        [Required]
        public int StateId { get; set; }

        public State State { get; set; }

        public List<Photo> Photos { get; set; }

        [Display(Name = "Created")]
        public DateTime Created { get; internal set; }
    }
}
