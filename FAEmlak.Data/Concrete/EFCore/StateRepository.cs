using System;
using System.Collections.Generic;
using System.Linq;
using FAEmlak.Data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace FAEmlak.Data.Concrete.EFCore
{
    public class StateRepository : Repository<State>, IStateRepository
    {
        public StateRepository(ApplicationContext context) : base(context)
        {
        }

        public List<State> GetStates()
        {
            return ApplicationContext.States.Include(i => i.City).ToList();
        }

        private ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
    }
}
