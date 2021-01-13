using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace XXG.ArticlePublisher.EntityFrameworkCore
{
    [DependsOn(
        typeof(ArticlePublisherEntityFrameworkCoreModule)
        )]
    public class ArticlePublisherEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ArticlePublisherMigrationsDbContext>();
        }
    }
}
