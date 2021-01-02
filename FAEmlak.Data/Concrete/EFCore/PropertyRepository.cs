using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAEmlak.Data.Abstract;
using FAEmlak.Data.Entity;
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

        public IQueryable<Property> GetProperties(SearchModel searchModel)
        {
            var result = ApplicationContext.Properties.Include(x => x.User).Include(x => x.State).ThenInclude(x => x.City).Include(x => x.Photos).AsQueryable();
            if (searchModel != null)
            {
                if (searchModel.Id.HasValue)
                    result = result.Where(x => x.PropertyId == searchModel.Id);
                if (!string.IsNullOrEmpty(searchModel.Name))
                    result = result.Where(x => x.Title.Contains(searchModel.Name));
                if (int.TryParse(searchModel.PriceFrom, out _))
                    result = result.Where(x => x.Price >= Convert.ToInt32(searchModel.PriceFrom));
                if (int.TryParse(searchModel.PriceTo, out _))
                    result = result.Where(x => x.Price <= Convert.ToInt32(searchModel.PriceTo));
                if (searchModel.StateId.HasValue)
                    result = result.Where(x => x.StateId == searchModel.StateId);
                if (searchModel.RoomCount.HasValue)
                    result = result.Where(x => x.RoomCount == searchModel.RoomCount);
                if (searchModel.PropertyType.HasValue)
                    result = result.Where(x => x.PropertyType == searchModel.PropertyType);
                if (searchModel.PropertyCategory.HasValue)
                    result = result.Where(x => x.PropertyCategory == searchModel.PropertyCategory);

            }
            return result;
        }

        private ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
        
    }
}
