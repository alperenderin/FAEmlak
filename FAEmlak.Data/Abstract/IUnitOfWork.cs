using System;
using System.Threading.Tasks;

namespace FAEmlak.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IPropertyRepository Properties { get; }
        IFavoriteItemRepository FavoriteItems { get; }
        Task<int> CommitAsync();
    }
}
