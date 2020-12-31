using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FAEmlak.Business.Abstract;
using FAEmlak.Data;
using FAEmlak.Data.Abstract;

namespace FAEmlak.Business.Concrete
{
    public class PhotoService : IPhotoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PhotoService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void Create(Photo entity)
        {
            _unitOfWork.Photos.Create(entity);
        }

        public void Update(Photo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Photo entity)
        {
            _unitOfWork.Photos.Delete(entity);
        }

        public Photo GetById(int id)
        {
            return _unitOfWork.Photos.GetById(id);
        }

        public async Task<Photo> GetPhotoByIdAsync(int id)
        {
            return await _unitOfWork.Photos.GetPhotoByIdAsync(id);
        }

        public async Task<List<Photo>> GetPhotosAsync()
        {
            return await _unitOfWork.Photos.GetPhotosAsync();
        }

        public async Task<List<Photo>> GetPhotosByPropertyId(int PropertyId)
        {
            return await _unitOfWork.Photos.GetPhotosByPropertyId(PropertyId);
        }
    }
}
