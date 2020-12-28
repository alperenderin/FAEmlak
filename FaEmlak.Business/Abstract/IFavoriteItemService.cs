using System;
using System.Collections.Generic;
using FAEmlak.Entity;

namespace FAEmlak.Business.Abstract
{
    public interface IFavoriteItemService
    {
        void Create(FavoriteItem entity);
        void Update(FavoriteItem entity);
        void Delete(FavoriteItem deneme);
        FavoriteItem GetById(int id);
        List<FavoriteItem> GetFavoriteItems(String UserId);
        bool IsFavorite(String UserId, int PropertyId);
    }
}
