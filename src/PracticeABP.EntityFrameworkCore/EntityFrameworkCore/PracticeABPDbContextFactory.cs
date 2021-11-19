using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PracticeABP.Configuration;
using PracticeABP.Web;

namespace PracticeABP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PracticeABPDbContextFactory : IDesignTimeDbContextFactory<PracticeABPDbContext>
    {
        public PracticeABPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PracticeABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PracticeABPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PracticeABPConsts.ConnectionStringName));

            return new PracticeABPDbContext(builder.Options);
        }
    }
}
