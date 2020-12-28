using System;
using System.Collections.Generic;
using FAEmlak.Entity;

namespace FAEmlak.Data.Abstract
{
    public interface IFavoriteItemRepository : IRepository<FavoriteItem>
    {
        List<FavoriteItem> GetFavoriteItems(String UserId);
        bool IsFavorite(String UserId, int PropertyId);
        FavoriteItem GetByUserIdAndPropertyId(String UserId, int PropertyId);
    }
}
