using System;
using System.Collections.Generic;
using FAEmlak.Business.Abstract;
using FAEmlak.Data.Abstract;
using FAEmlak.Entity;

namespace FAEmlak.Business.Concrete
{
    public class FavoriteItemService : IFavoriteItemService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FavoriteItemService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void Create(FavoriteItem entity)
        {
            _unitOfWork.FavoriteItems.Create(entity);
        }

        public void Delete(FavoriteItem entity)
        {
            _unitOfWork.FavoriteItems.Delete(entity);
        }

        public FavoriteItem GetById(int id)
        {
            return _unitOfWork.FavoriteItems.GetById(id);
        }

        public List<FavoriteItem> GetFavoriteItems(String UserId)
        {
            return _unitOfWork.FavoriteItems.GetFavoriteItems(UserId);
        }

        public void Update(FavoriteItem entity)
        {
            throw new NotImplementedException();
        }

        public bool IsFavorite(string UserId, int PropertyId)
        {
            return _unitOfWork.FavoriteItems.IsFavorite(UserId, PropertyId);
        }
    }
}
