using System;
using System.Collections.Generic;
using System.Linq;
using FAEmlak.Data.Abstract;
using FAEmlak.Entity;
using Microsoft.EntityFrameworkCore;

namespace FAEmlak.Data.Concrete.EFCore
{
    public class FavoriteItemRepository : Repository<FavoriteItem>, IFavoriteItemRepository
    {
        public FavoriteItemRepository(ApplicationContext context) : base(context)
        {

        }

        public List<FavoriteItem> GetFavoriteItems(String UserId)
        {
            var favoriteItems = ApplicationContext.FavoriteItems.Include(i => i.Property).ThenInclude(i => i.State).ThenInclude(i=> i.City).Where(i => i.UserId == UserId).ToList();
            return favoriteItems;
        }

        private ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
    }
}
