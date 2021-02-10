using Laba45Tsi.Storage;
using Laba45Tsi.Storage.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45Tsi.Managers.producerManager
{
    public class producerManager : iProducerManager
    {
        private readonly dbContext _dbContext;
        private readonly IWebHostEnvironment _hostEnvironment;

        public producerManager(dbContext dbContext, IWebHostEnvironment hostEnvironment)
        {
            _dbContext = dbContext;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<producerEntity> addProducerEntity(string request)
        {
            var entity = new producerEntity
            {
                name = request
            };

            _dbContext.producers.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyCollection<producerEntity>> getAll()
        {
            var query = _dbContext.producers
                .OrderBy(st => st.name)
                .AsNoTracking();

            var entities = await query.ToListAsync();

            return entities;
        }

        public async Task<producerEntity> updateProduser(Guid id, string request)
        {
            var entity = await _dbContext.producers.FirstOrDefaultAsync(g => g.id == id);

            entity.name = request;

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<producerEntity> getById(Guid id)
        {
            return await _dbContext.producers.FirstOrDefaultAsync(g => g.id == id);
        }

        public async Task<producerEntity> dellProducerEntity(Guid id)
        {
            var entyti = _dbContext.producers
                            .Where(o => o.id == id)
                            .FirstOrDefault();

            _dbContext.producers.Remove(entyti);

            await _dbContext.SaveChangesAsync();

            return entyti;
        }

    }
}
