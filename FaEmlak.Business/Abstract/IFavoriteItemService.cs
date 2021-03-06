﻿using FAEmlak.Data;
using System;
using System.Collections.Generic;

namespace FAEmlak.Business.Abstract
{
    public interface IFavoriteItemService
    {
        void Create(FavoriteItem entity);
        void Update(FavoriteItem entity);
        void Delete(FavoriteItem deneme);
        FavoriteItem GetById(int id);
        FavoriteItem GetByUserIdAndPropertyId(String UserId, int PropertyId);
        List<FavoriteItem> GetFavoriteItems(String UserId);
        bool IsFavorite(String UserId, int PropertyId);
    }
}
