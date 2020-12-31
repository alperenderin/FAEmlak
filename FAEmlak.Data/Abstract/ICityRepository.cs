using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FAEmlak.Data.Abstract
{
    public interface ICityRepository : IRepository<City>
    {
        Task<List<City>> GetCitiesAsync();
        Task<City> GetCityWithStatesByIdAsync(int id);
    }
}
