using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ruito.EntityFrameworkCore
{
    public static class ruitoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ruitoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ruitoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
