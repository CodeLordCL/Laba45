using Laba45Tsi.Storage.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45Tsi.Storage
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }

        public DbSet<filmEntity> films { get; set; }

        public DbSet<genreEntity> genres { get; set; }

        public DbSet<producerEntity> producers { get; set; }
    }
}
