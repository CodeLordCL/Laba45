using Laba45Tsi.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45Tsi.Managers.genreManager
{
    public interface iGenreManager
    {
        public Task<genreEntity> addGenreEntity(string request);

        public Task<IReadOnlyCollection<genreEntity>> getAll();

        public Task<genreEntity> updateGenre(Guid id, string request);

        public Task<genreEntity> getById(Guid id);

        public Task<genreEntity> dellGenreEntity(Guid id);
    }
}
