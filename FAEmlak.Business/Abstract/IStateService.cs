using FAEmlak.Data;
using System;
using System.Collections.Generic;

namespace FAEmlak.Business.Abstract
{
    public interface IStateService
    {
        void Create(State entity);
        void Update(State entity);
        void Delete(State entity);
        State GetById(int id);
        List<State> GetStates();
    }
}