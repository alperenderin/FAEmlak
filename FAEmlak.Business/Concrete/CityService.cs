using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FAEmlak.Business.Abstract;
using FAEmlak.Data;
using FAEmlak.Data.Abstract;

namespace FAEmlak.Business.Concrete
{
    public class CityService : ICityService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(City entity)
        {
            _unitOfWork.Cities.Create(entity);
        }

        public void Delete(City entity)
        {
            _unitOfWork.Cities.Delete(entity);
        }

        public City GetById(int id)
        {
            return _unitOfWork.Cities.GetById(id);
        }

        public async Task<List<City>> GetCitiesAsync()
        {
            return await _unitOfWork.Cities.GetCitiesAsync();
        }

        public async Task<City> GetCityWithStatesByIdAsync(int id)
        {
            return await _unitOfWork.Cities.GetCityWithStatesByIdAsync(id);
        }

        public void Update(City entity)
        {
            _unitOfWork.Cities.Update(entity);
        }
    }
}
