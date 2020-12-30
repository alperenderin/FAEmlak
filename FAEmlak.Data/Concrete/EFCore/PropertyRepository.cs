﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAEmlak.Data.Abstract;
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
            var Properties = ApplicationContext.Properties.Include(i => i.State).ThenInclude(i => i.City).ToList();
            return Properties;
        }

        public List<Property> GetPropertiesByTypeAndCategory(PropertyType Type, PropertyCategory Category)
        {
            var Properties = ApplicationContext.Properties.
                Include(i => i.State).
                ThenInclude(i => i.City).
                Where(i => i.PropertyType == Type).
                Where(i => i.PropertyCategory == Category).ToList();

            return Properties;
        }

        public async Task<Property> GetPropertyByIdAsync(int id)
        {
            return await ApplicationContext.Properties.Where(i => i.PropertyId == id).Include(i => i.State).ThenInclude(i => i.City).Include(i => i.User).FirstOrDefaultAsync();
        }

        private ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
    }
}
