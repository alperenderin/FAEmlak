using FAEmlak.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FAEmlak.Business.Abstract
{
    public interface IPhotoService
    {
        void Create(Photo entity);
        void Update(Photo entity);
        void Delete(Photo entity);
        Photo GetById(int id);
        Task<Photo> GetPhotoByIdAsync(int id);
        Task<List<Photo>> GetPhotosByPropertyId(int PropertyId);
        Task<List<Photo>> GetPhotosAsync();
    }
}