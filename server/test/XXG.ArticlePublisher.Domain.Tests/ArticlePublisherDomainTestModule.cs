using XXG.ArticlePublisher.MongoDB;
using Volo.Abp.Modularity;

namespace XXG.ArticlePublisher
{
    [DependsOn(
        typeof(ArticlePublisherMongoDbTestModule)
        )]
    public class ArticlePublisherDomainTestModule : AbpModule
    {

    }
}