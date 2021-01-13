using XXG.ArticlePublisher.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace XXG.ArticlePublisher
{
    [DependsOn(
        typeof(ArticlePublisherEntityFrameworkCoreTestModule)
        )]
    public class ArticlePublisherDomainTestModule : AbpModule
    {

    }
}