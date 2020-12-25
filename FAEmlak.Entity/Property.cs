using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FAEmlak.Entity
{
    public class Property
    {
        public Property()
        {
            Created = DateTime.UtcNow;
        }

        [Key]
        public int PropertyId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int Area { get; set; }
        public string Description { get; set; }

        public PropertyType PropertyType { get; set; }
        public PropertyCategory PropertyCategory { get; set; }
        public PropertyStatus Status { get; set; }

        public bool HasBalcony { get; set; }
        public bool HasStuff { get; set; }
        public byte BuildingAge { get; set; }
        public byte BathroomCount { get; set; }
        public bool IsInSite { get; set; }
        public byte FloorCount { get; set; }
        public byte WhichFloor { get; set; } 

        public int StateId { get; set; }
        public State State { get; set; }

        public List<Photo> Photos { get; set; }

        public DateTime Created { get; internal set; }

    }
}

