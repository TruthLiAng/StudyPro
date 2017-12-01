using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace StudyPro.EntityFrameworkCore
{
    public static class StudyProDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<StudyProDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<StudyProDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
