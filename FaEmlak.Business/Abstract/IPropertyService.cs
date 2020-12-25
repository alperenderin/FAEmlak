using System;
using System.Collections.Generic;
using FAEmlak.Entity;

namespace FAEmlak.Business.Abstract
{
    public interface IPropertyService
    {
        void Create(Property entity);
        void Update(Property entity);
        void Delete(Property deneme);
        Property GetById(int id);
        List<Property> GetProperties();
        List<Property> GetPropertiesByTypeAndCategory(PropertyType propertyType, PropertyCategory propertyCategory);
    }
}
