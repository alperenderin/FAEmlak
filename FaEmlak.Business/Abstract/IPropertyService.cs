using FAEmlak.Data;
using System;
using System.Collections.Generic;

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
