using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Slarkerino.Crawler.Tieba.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class TiebaDbContextFactory : IDesignTimeDbContextFactory<TiebaDbContext>
    {
        public TiebaDbContext CreateDbContext(string[] args)
        {
            TiebaEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<TiebaDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"), MySqlServerVersion.LatestSupportedServerVersion);

            return new TiebaDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Slarkerino.Crawler.Tieba.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
