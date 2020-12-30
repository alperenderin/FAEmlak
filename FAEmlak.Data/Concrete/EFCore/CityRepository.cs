using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAEmlak.Data.Abstract;
using FAEmlak.Entity;
using Microsoft.EntityFrameworkCore;

namespace FAEmlak.Data.Concrete.EFCore
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(ApplicationContext context) : base(context)
        {
        }

        public async Task<List<City>> GetCitiesAsync()
        {
            return await ApplicationContext.Cities.Include(i => i.States).ToListAsync();
        }

        public async Task<City> GetCityWithStatesByIdAsync(int id)
        {
            return await ApplicationContext.Cities.Include(i => i.States).Where(i => i.CityId == id).FirstOrDefaultAsync();
        }

        private ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
    }
}
