using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using XXG.ArticlePublisher.Data;
using Volo.Abp.DependencyInjection;

namespace XXG.ArticlePublisher.EntityFrameworkCore
{
    public class EntityFrameworkCoreArticlePublisherDbSchemaMigrator
        : IArticlePublisherDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreArticlePublisherDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ArticlePublisherMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ArticlePublisherMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}