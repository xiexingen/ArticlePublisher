using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace XXG.ArticlePublisher.MongoDB
{
    [DependsOn(
        typeof(ArticlePublisherTestBaseModule),
        typeof(ArticlePublisherMongoDbModule)
        )]
    public class ArticlePublisherMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var stringArray = ArticlePublisherMongoDbFixture.ConnectionString.Split('?');
                        var connectionString = stringArray[0].EnsureEndsWith('/')  +
                                                   "Db_" +
                                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}
