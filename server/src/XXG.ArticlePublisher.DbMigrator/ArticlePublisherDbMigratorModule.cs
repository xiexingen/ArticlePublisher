using XXG.ArticlePublisher.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace XXG.ArticlePublisher.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ArticlePublisherMongoDbModule),
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
