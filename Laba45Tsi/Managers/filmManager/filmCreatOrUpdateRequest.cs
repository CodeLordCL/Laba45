using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45Tsi.Managers.filmManager
{
    public class filmCreatOrUpdateRequest
    {
        public string filmName { get; set; }

        public Guid genreId { get; set; }

        public string genreName { get; set; }

        public Guid producerId { get; set; }

        public string producerName { get; set; }
    }
}
