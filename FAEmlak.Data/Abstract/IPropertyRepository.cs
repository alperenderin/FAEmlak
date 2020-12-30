using System;
using System.Collections.Generic;

namespace FAEmlak.Data.Abstract
{
    public interface IPropertyRepository : IRepository<Property>
    {
        List<Property> GetProperties();
        List<Property> GetPropertiesByTypeAndCategory(PropertyType Type, PropertyCategory Category);
    }
}
