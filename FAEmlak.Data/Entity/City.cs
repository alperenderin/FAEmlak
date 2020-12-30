using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FAEmlak.Data
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public List<State> States { get; set; }
    }
}
