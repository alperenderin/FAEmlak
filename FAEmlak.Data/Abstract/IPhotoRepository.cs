using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FAEmlak.Data.Abstract
{
    public interface IPhotoRepository : IRepository<Photo>
    {
        Task<List<Photo>> GetPhotosAsync();
        Task<Photo> GetPhotoByIdAsync(int id);
        Task<List<Photo>> GetPhotosByPropertyId(int PropertyId);
    }
}
