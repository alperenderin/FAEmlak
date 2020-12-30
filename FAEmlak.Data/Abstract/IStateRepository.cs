using System;
using System.Collections.Generic;

namespace FAEmlak.Data.Abstract
{
    public interface IStateRepository : IRepository<State>
    {
        List<State> GetStates();
    }
}
