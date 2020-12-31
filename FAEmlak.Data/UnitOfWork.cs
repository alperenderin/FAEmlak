using System;
using System.Threading.Tasks;
using FAEmlak.Data.Abstract;
using FAEmlak.Data.Concrete.EFCore;

namespace FAEmlak.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        private PropertyRepository _propertyRepository;
        private FavoriteItemRepository _favoriteItemRepository;
        private CityRepository _cityRepository;
        private StateRepository _stateRepository;
        private PhotoRepository _photoRepository;

        public UnitOfWork(ApplicationContext context) 
        {
            _context = context;
        }

        public IPropertyRepository Properties => _propertyRepository = _propertyRepository ?? new PropertyRepository(_context);
        public IFavoriteItemRepository FavoriteItems => _favoriteItemRepository = _favoriteItemRepository ?? new FavoriteItemRepository(_context);
        public ICityRepository Cities => _cityRepository = _cityRepository ?? new CityRepository(_context);
        public IStateRepository States => _stateRepository = _stateRepository ?? new StateRepository(_context);
        public IPhotoRepository Photos => _photoRepository = _photoRepository ?? new PhotoRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
