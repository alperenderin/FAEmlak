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

        public int PropertyId { get; set; }
        public int Price { get; set; }
        public int Area { get; set; }
        public string Description { get; set; }

        public PropertyType PropertyType { get; set; }
        public PropertyStatus Status { get; set; }
        public DateTime Created { get; internal set; }

        public long CityId { get; set; }
        public City City { get; set; }


        public long StateId { get; set; }
        public State State { get; set; }


        public List<Photo> Photos { get; set; }  
    }
}
