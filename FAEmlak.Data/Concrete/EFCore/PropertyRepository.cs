using System;
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

        public async Task<List<Property>> GetPropertiesAsync()
        {
            return await ApplicationContext.Properties.Include(i => i.State).ThenInclude(i => i.City).Include(i => i.Photos).ToListAsync();
        }

        public async Task<List<Property>> GetPropertiesByTypeAndCategoryAsync(PropertyType Type, PropertyCategory Category)
        {
            var Properties = await ApplicationContext.Properties.
                Include(i => i.State).
                ThenInclude(i => i.City).
                Include(i => i.Photos).
                Where(i => i.PropertyType == Type).
                Where(i => i.PropertyCategory == Category).ToListAsync();

            return Properties;
        }

        public async Task<Property> GetPropertyByIdAsync(int id)
        {
            return await ApplicationContext.Properties.Where(i => i.PropertyId == id).Include(i => i.State).ThenInclude(i => i.City).Include(i => i.User).Include(i => i.Photos).FirstOrDefaultAsync();
        }

        public async Task<List<Property>> GetPropertiesByUserId(string UserId)
        {
            return await ApplicationContext.Properties.Include(i => i.State).ThenInclude(i => i.City).Include(i => i.Photos).Include(i=>i.User).Where(i => i.UserId == UserId).ToListAsync();
        }

        private ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
    }
}
