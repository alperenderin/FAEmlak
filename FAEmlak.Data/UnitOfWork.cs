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

        public UnitOfWork(ApplicationContext context) 
        {
            _context = context;
        }

        public IPropertyRepository Properties => _propertyRepository = _propertyRepository ?? new PropertyRepository(_context);

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
