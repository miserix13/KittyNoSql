using Microsoft.EntityFrameworkCore;
using NoSqlWrapper.Data.Entity;

namespace NoSqlWrapper.Data
{
    public class NoSQLContext : DbContext
    {
        public DbSet<StoreEntity> Store { get; set; }
        public DbSet<StoreArchiveEntity> StoreArchive { get; set; }
        public DbSet<TypeVersionEntity> TypeVersion { get; set; }
    }
}
