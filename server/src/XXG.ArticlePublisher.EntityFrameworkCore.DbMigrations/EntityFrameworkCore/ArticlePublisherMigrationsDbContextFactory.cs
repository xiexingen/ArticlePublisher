using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace XXG.ArticlePublisher.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ArticlePublisherMigrationsDbContextFactory : IDesignTimeDbContextFactory<ArticlePublisherMigrationsDbContext>
    {
        public ArticlePublisherMigrationsDbContext CreateDbContext(string[] args)
        {
            ArticlePublisherEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ArticlePublisherMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ArticlePublisherMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../XXG.ArticlePublisher.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
