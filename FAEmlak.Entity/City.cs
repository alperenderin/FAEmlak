using System;
using System.Collections.Generic;

namespace FAEmlak.Entity
{
    public class City
    {
        public int CityId { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }

        public List<State> States { get; set; }
    }
}
