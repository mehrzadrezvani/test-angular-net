using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace angular-net.EntityFrameworkCore
{
    public static class angular-netDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<angular-netDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<angular-netDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
