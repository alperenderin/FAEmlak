using System;
using System.Collections.Generic;
using FAEmlak.Entity;

namespace FAEmlak.Data.Abstract
{
    public interface IPropertyRepository : IRepository<Property>
    {
        List<Property> GetProperties();
    }
}
