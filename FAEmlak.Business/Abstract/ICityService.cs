using FAEmlak.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FAEmlak.Business.Abstract
{
    public interface ICityService
    {
        void Create(City entity);
        void Update(City entity);
        void Delete(City entity);
        City GetById(int id);
        Task<City> GetCityWithStatesByIdAsync(int id);
        Task<List<City>> GetCitiesAsync();
    }
}