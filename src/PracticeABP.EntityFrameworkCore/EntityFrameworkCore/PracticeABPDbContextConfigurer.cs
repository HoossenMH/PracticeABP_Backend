using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PracticeABP.EntityFrameworkCore
{
    public static class PracticeABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PracticeABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PracticeABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
