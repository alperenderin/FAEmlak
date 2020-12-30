using FAEmlak.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FAEmlak.Business.Abstract
{
    public interface IPropertyService
    {
        void Create(Property entity);
        void Update(Property entity);
        void Delete(Property deneme);
        Property GetById(int id);
        Task<Property> GetPropertyByIdAsync(int id);
        List<Property> GetProperties();
        List<Property> GetPropertiesByTypeAndCategory(PropertyType propertyType, PropertyCategory propertyCategory);
    }
}
