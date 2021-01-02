using FAEmlak.Data;
using FAEmlak.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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
        Task<List<Property>> GetPropertiesAsync();
        Task<List<Property>> GetPropertiesByUserId(string UserId);
        Task<List<Property>> GetPropertiesByTypeAndCategoryAsync(PropertyType propertyType, PropertyCategory propertyCategory);
        IQueryable<Property> GetProperties(SearchModel searchModel);
    }
}
