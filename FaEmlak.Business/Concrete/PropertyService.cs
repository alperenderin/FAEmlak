using System;
using System.Collections.Generic;
using FAEmlak.Business.Abstract;
using FAEmlak.Data.Abstract;
using FAEmlak.Entity;

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
            throw new NotImplementedException();
        }

        public void Delete(Property entity)
        {
            _unitOfWork.Properties.Delete(entity);
        }

        public Property GetById(int id)
        {
            return _unitOfWork.Properties.GetById(id);
        }

        public List<Property> GetProperties()
        {
            return _unitOfWork.Properties.GetProperties();
        }

        public List<Property> GetPropertiesByTypeAndCategory(PropertyType propertyType, PropertyCategory propertyCategory)
        {
            return _unitOfWork.Properties.GetPropertiesByTypeAndCategory(propertyType, propertyCategory);
        }
    }
}
