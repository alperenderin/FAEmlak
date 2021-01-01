using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAEmlak.Data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace FAEmlak.Data.Concrete.EFCore
{
    public class PhotoRepository : Repository<Photo>, IPhotoRepository
    {
        public PhotoRepository(ApplicationContext context) : base(context)
        {

        }

        public async Task<List<Photo>> GetPhotosAsync()
        {
            return await ApplicationContext.Photos.ToListAsync();
        }

        public async Task<Photo> GetPhotoByIdAsync(int id)
        {
            return await ApplicationContext.Photos.Where(i => i.PhotoId == id).FirstOrDefaultAsync();
        }

        public async Task<List<Photo>> GetPhotosByPropertyId(int PropertyId)
        {
            return await ApplicationContext.Photos.Where(i => i.PropertyId == PropertyId).ToListAsync();
        }

        private ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
    }
}
