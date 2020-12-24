using System;
using System.Collections.Generic;
using System.Linq;
using FAEmlak.Data.Abstract;
using FAEmlak.Entity;
using Microsoft.EntityFrameworkCore;

namespace FAEmlak.Data.Concrete.EFCore
{
    public class PropertyRepository : Repository<Property>, IPropertyRepository
    {
        public PropertyRepository(ApplicationContext context) : base(context)
        {

        }

        public List<Property> GetProperties()
        {
            var Properties = ApplicationContext.Properties.Include(i => i.Photos).ToList();
            return Properties;
        }

        private ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
    }
}
