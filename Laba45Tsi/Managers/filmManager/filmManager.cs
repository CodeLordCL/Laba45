using Laba45Tsi.Storage;
using Laba45Tsi.Storage.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45Tsi.Managers.filmManager
{
    public class filmManager : iFilmManager
    {
        private readonly dbContext _dbContext;
        private readonly IWebHostEnvironment _hostEnvironment;

        public filmManager(dbContext dbContext, IWebHostEnvironment hostEnvironment)
        {
            _dbContext = dbContext;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<filmEntity> addFilmEntity(filmCreatOrUpdateRequest request)
        {
            var entity = new filmEntity
            {
                filmName = request.filmName,

                genreId = request.genreId,

                genreName = request.genreName,

                producerId = request.producerId,

                producerName = request.producerName
            };

            _dbContext.films.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyCollection<filmEntity>> getAllByProducer(Guid id)
        {
            var query = from item in _dbContext.films
                        where item.producerId == id
                        select item;

            var entities = await query.ToListAsync();

            return entities;
        }

        public async Task<IReadOnlyCollection<filmEntity>> getAllByGenre(Guid id)
        {
            var query = from item in _dbContext.films
                        where item.genreId == id
                        select item;

            var entities = await query.ToListAsync();

            return entities;
        }

        public producerEntity getProducerById(Guid id)
        {
            var entyti = _dbContext.producers
                            .Where(o => o.id == id)
                            .FirstOrDefault();

            return entyti;
        }

        public genreEntity getGenreById(Guid id)
        {
            var entyti = _dbContext.genres
                            .Where(o => o.id == id)
                            .FirstOrDefault();

            return entyti;
        }

        public filmEntity getFilmById(Guid id)
        {
            var entyti = _dbContext.films
                            .Where(o => o.id == id)
                            .FirstOrDefault();

            return entyti;
        }

        public async Task<filmEntity> dellFilmEntity(Guid id)
        {
            var entyti = _dbContext.films
                            .Where(o => o.id == id)
                            .FirstOrDefault();

            _dbContext.films.Remove(entyti);

            await _dbContext.SaveChangesAsync();

            return entyti;
        }

        public async Task<filmEntity> updateFilm(Guid id, filmCreatOrUpdateRequest request)
        {
            var entity = await _dbContext.films.FirstOrDefaultAsync(g => g.id == id);

            entity.filmName = request.filmName;

            entity.genreId = request.genreId;

            entity.genreName = request.genreName;

            entity.producerId = request.producerId;

            entity.producerName = request.producerName;

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<producerEntity> getProducerByName(string name)
        {
            var item = await _dbContext.producers.FirstOrDefaultAsync(g => g.name == name);

            return item;
        }

        public async Task<genreEntity> getGenreByName(string name)
        {
            var item = await _dbContext.genres.FirstOrDefaultAsync(g => g.genreName == name);

            return item;
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
    }
}
