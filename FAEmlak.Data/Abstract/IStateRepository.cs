using System;
using System.Collections.Generic;
using FAEmlak.Entity;

namespace FAEmlak.Data.Abstract
{
    public interface IStateRepository : IRepository<State>
    {
        List<State> GetStates();
    }
}
