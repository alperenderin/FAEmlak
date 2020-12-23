using System;
namespace FAEmlak.Entity
{
    public class State
    {
        public State()
        {
        }

        public int StateId { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
