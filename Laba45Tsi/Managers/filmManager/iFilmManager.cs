using Laba45Tsi.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45Tsi.Managers.filmManager
{
    public interface iFilmManager
    {
        public Task<filmEntity> addFilmEntity(filmCreatOrUpdateRequest request);

        public Task<IReadOnlyCollection<filmEntity>> getAllByProducer(Guid id);

        public Task<IReadOnlyCollection<filmEntity>> getAllByGenre(Guid id);

        public producerEntity getProducerById(Guid id);

        public genreEntity getGenreById(Guid id);

        public filmEntity getFilmById(Guid id);

        public Task<filmEntity> dellFilmEntity(Guid id);

        public Task<filmEntity> updateFilm(Guid id, filmCreatOrUpdateRequest request);

        public Task<producerEntity> getProducerByName(string name);

        public Task<genreEntity> getGenreByName(string name);

        public Task<genreEntity> addGenreEntity(string request);

        public Task<producerEntity> addProducerEntity(string request);
    }
}
