using System;
using System.Threading.Tasks;

namespace FAEmlak.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IPropertyRepository Properties { get; }
        IFavoriteItemRepository FavoriteItems { get; }
        ICityRepository Cities { get; }
        IStateRepository States { get; }
        IPhotoRepository Photos { get; }
        Task<int> CommitAsync();
    }
}
