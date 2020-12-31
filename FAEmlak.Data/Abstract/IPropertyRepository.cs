using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FAEmlak.Data.Abstract
{
    public interface IPropertyRepository : IRepository<Property>
    {
        Task<List<Property>> GetPropertiesAsync();
        Task<Property> GetPropertyByIdAsync(int id);
        Task<List<Property>> GetPropertiesByUserId(string UserId);
        Task<List<Property>> GetPropertiesByTypeAndCategoryAsync(PropertyType Type, PropertyCategory Category);
    }
}
