using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAEmlak.Data.Entity;

namespace FAEmlak.Data.Abstract
{
    public interface IPropertyRepository : IRepository<Property>
    {
        Task<List<Property>> GetPropertiesAsync();
        Task<Property> GetPropertyByIdAsync(int id);
        Task<List<Property>> GetPropertiesByUserId(string UserId);
        Task<List<Property>> GetPropertiesByTypeAndCategoryAsync(PropertyType Type, PropertyCategory Category);
        IQueryable<Property> GetProperties(SearchModel searchModel);
    }
}
