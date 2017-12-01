using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using StudyPro.Configuration;
using StudyPro.Web;

namespace StudyPro.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class StudyProDbContextFactory : IDesignTimeDbContextFactory<StudyProDbContext>
    {
        public StudyProDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<StudyProDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            StudyProDbContextConfigurer.Configure(builder, configuration.GetConnectionString(StudyProConsts.ConnectionStringName));

            return new StudyProDbContext(builder.Options);
        }
    }
}
