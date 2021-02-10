using Laba45Tsi.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45Tsi.Managers.producerManager
{
    public interface iProducerManager
    {
        public Task<producerEntity> addProducerEntity(string request);

        public Task<IReadOnlyCollection<producerEntity>> getAll();

        public Task<producerEntity> updateProduser(Guid id, string request);

        public Task<producerEntity> getById(Guid id);

        public Task<producerEntity> dellProducerEntity(Guid id);

    }
}
