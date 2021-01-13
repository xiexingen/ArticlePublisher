using Volo.Abp.Modularity;

namespace XXG.ArticlePublisher
{
    [DependsOn(
        typeof(ArticlePublisherApplicationModule),
        typeof(ArticlePublisherDomainTestModule)
        )]
    public class ArticlePublisherApplicationTestModule : AbpModule
    {

    }
}