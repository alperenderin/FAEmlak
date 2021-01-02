using System;
using FAEmlak.Data;

namespace FAEmlak.Data.Entity
{
    public class SearchModel
    {
        public int? Id { get; set; }
        public string PriceFrom { get; set; }
        public string PriceTo { get; set; }
        public string Name { get; set; }
        public RoomCount? RoomCount { get; set; }
        public PropertyCategory? PropertyCategory { get; set; }
        public PropertyType? PropertyType { get; set; }
        public int? StateId { get; set; }
    }
}
