using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FAEmlak.Data.Abstract
{
    public interface IPropertyRepository : IRepository<Property>
    {
        List<Property> GetProperties();
        Task<Property> GetPropertyByIdAsync(int id);
        Task<List<Property>> GetPropertiesByUserId(string UserId);
        List<Property> GetPropertiesByTypeAndCategory(PropertyType Type, PropertyCategory Category);
    }
}
