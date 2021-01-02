using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAEmlak.Business.Abstract;
using FAEmlak.Data;
using FAEmlak.Data.Abstract;
using FAEmlak.Data.Entity;

namespace FAEmlak.Business.Concrete
{
    public class PropertyService : IPropertyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PropertyService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void Create(Property entity)
        {
            _unitOfWork.Properties.Create(entity);
        }

        public void Update(Property entity)
        {
            _unitOfWork.Properties.Update(entity);
        }

        public void Delete(Property entity)
        {
            _unitOfWork.Properties.Delete(entity);
        }

        public Property GetById(int id)
        {
            return _unitOfWork.Properties.GetById(id);
        }

        public async Task<List<Property>> GetPropertiesAsync()
        {
            return await _unitOfWork.Properties.GetPropertiesAsync();
        }

        public async Task<List<Property>> GetPropertiesByTypeAndCategoryAsync(PropertyType propertyType, PropertyCategory propertyCategory)
        {
            return await _unitOfWork.Properties.GetPropertiesByTypeAndCategoryAsync(propertyType, propertyCategory);
        }

        public async Task<Property> GetPropertyByIdAsync(int id)
        {
            return await _unitOfWork.Properties.GetPropertyByIdAsync(id);
        }

        public async Task<List<Property>> GetPropertiesByUserId(string UserId)
        {
            return await _unitOfWork.Properties.GetPropertiesByUserId(UserId);
        }

        public IQueryable<Property> GetProperties(SearchModel searchModel)
        {
            return _unitOfWork.Properties.GetProperties(searchModel);
        }
    }
}
