using Laba45Tsi.Storage;
using Laba45Tsi.Storage.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45Tsi.Managers.genreManager
{
    public class genreManager : iGenreManager
    {
        private readonly dbContext _dbContext;
        private readonly IWebHostEnvironment _hostEnvironment;

        public genreManager(dbContext dbContext, IWebHostEnvironment hostEnvironment)
        {
            _dbContext = dbContext;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<genreEntity> addGenreEntity(string request)
        {
            var entity = new genreEntity
            {
                genreName = request    
            };

            _dbContext.genres.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyCollection<genreEntity>> getAll()
        {
            var query = _dbContext.genres
                .OrderBy(st => st.genreName)
                .AsNoTracking();

            var entities = await query.ToListAsync();

            return entities;
        }

        public async Task<genreEntity> updateGenre(Guid id, string request)
        {
            var entity = await _dbContext.genres.FirstOrDefaultAsync(g => g.id == id);

            entity.genreName = request;

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<genreEntity> getById(Guid id)
        {
            return await _dbContext.genres.FirstOrDefaultAsync(g => g.id == id);
        }

        public async Task<genreEntity> dellGenreEntity(Guid id)
        {
            var entyti = _dbContext.genres
                            .Where(o => o.id == id)
                            .FirstOrDefault();

            _dbContext.genres.Remove(entyti);

            await _dbContext.SaveChangesAsync();

            return entyti;
        }

    }
}
