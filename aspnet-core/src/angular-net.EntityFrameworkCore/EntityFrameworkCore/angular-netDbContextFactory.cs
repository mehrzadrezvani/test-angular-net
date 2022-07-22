using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using angular-net.Configuration;
using angular-net.Web;

namespace angular-net.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class angular-netDbContextFactory : IDesignTimeDbContextFactory<angular-netDbContext>
    {
        public angular-netDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<angular-netDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            angular-netDbContextConfigurer.Configure(builder, configuration.GetConnectionString(angular-netConsts.ConnectionStringName));

            return new angular-netDbContext(builder.Options);
        }
    }
}
