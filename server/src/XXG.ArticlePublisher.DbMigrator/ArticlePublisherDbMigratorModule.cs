using XXG.ArticlePublisher.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace XXG.ArticlePublisher.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ArticlePublisherEntityFrameworkCoreDbMigrationsModule),
        typeof(ArticlePublisherApplicationContractsModule)
        )]
    public class ArticlePublisherDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
